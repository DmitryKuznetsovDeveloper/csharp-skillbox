using PracticalWork010.Interface;
using PracticalWork010.Model;

namespace PracticalWork010.Controller;

public class ControllerBank
{
    private CustomerData _customerData;
    private Consultant _workerBank;
    private IView _view;

    public ControllerBank(CustomerData customerData, Consultant workerBank, IView view)
    {
        _customerData = customerData;
        _workerBank = workerBank;
        _view = view;
    }
    public virtual void Start()
    {
        bool start = true;
        while (start)
        {
            Console.WriteLine(_view.Menu);
            Console.Write(_view.InputUser);
            int menuItem = Convert.ToInt32(Console.ReadLine());
            switch (menuItem)
            {
                case 1:
                    if (_customerData.ListNotes.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(_view.EmptyFile);
                    }
                    else _workerBank.PrintAllWorker(_customerData.ListNotes);

                    break;
                case 2:
                    Console.Clear();
                    Console.Write(_view.InputUserIdPhone);
                    long idPhone = Convert.ToInt64(Console.ReadLine());
                    _workerBank.ChangeCustomerPhoneNumber(_workerBank.GetWorkerById(_customerData.ListNotes,idPhone));
                    _customerData.UpdateFile();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write(_view.InputUserId);
                    long id = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine(_workerBank.GetWorkerById(_customerData.ListNotes, id));
                    break;
                case 4:
                    Console.Clear();
                    _workerBank.AddedNoteClient(_customerData.ListNotes,_customerData.PathFileWorkers);
                    _customerData.UpdateFile();
                    if (_workerBank is Manager)Console.WriteLine(_view.SuccessfullyAddedWorker);
                    break;
                case 5:
                    start = false;
                    break;
            }
        }
    }
}