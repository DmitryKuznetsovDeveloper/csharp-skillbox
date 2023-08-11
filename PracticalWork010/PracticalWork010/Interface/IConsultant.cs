namespace PracticalWork010.Interface;

public interface IConsultant
{
    public void PrintAllWorker(List<INote> listNotes);
    public INote GetWorkerById(List<INote> listNotes, long id);
    public void ChangeCustomerPhoneNumber(INote client);
}