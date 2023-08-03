namespace PracticalWork007.Interface;

public interface INote
{
    public long Id { get; }
    public IWorker Worker { get; set; }
    public DateTime DateTimeEntryWasAdded { get; set; }
}