using PracticalWork010.Controller;
using PracticalWork010.Interface;
using PracticalWork010.Model;

namespace PracticalWork010;

internal class Program
{
    public static void Main(string[] args)
    {
        CustomerData customerData = new CustomerData();
        IView view = new View();

        Console.WriteLine("Выберите кем будете заходить:\n" +
                          "1: Консультант\n" +
                          "2: Менеджер\n");
        int result = Convert.ToInt32(Console.ReadLine());
        
        if (result == 1)
        {
            Consultant consultant = new Consultant();
            ControllerBank controllerBank1 = new ControllerBank(customerData, consultant, view);
            controllerBank1.Start();
        }

        if (result == 2)
        {
            Manager manager = new Manager();
            ControllerBank controllerBank2 = new ControllerBank(customerData, manager, view);
            controllerBank2.Start();
        }
        


    }
}
