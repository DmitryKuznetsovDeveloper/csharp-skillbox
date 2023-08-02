using PracticalWork006.Interface;

namespace PracticalWork006;

public class Note : INote
{
    public long Id { get; set; }
    public DateTime DateTimeEntryWasAdded { get; set; }
    public IWorker Worker { get; set; }

    public Note()
    {
        Console.Write("Введите ID -> "); 
        Id = Convert.ToInt64(Console.ReadLine());
        Worker = new Worker();
        DateTimeEntryWasAdded = DateTime.Now;
    }
    
    public Note(long id,DateTime dateTimeEntryWasAdded, Worker worker )
    {
        Id = id;
        Worker = worker;
        DateTimeEntryWasAdded = dateTimeEntryWasAdded;
    }

    public override string ToString() => $"\nID: {Id}\n" +
                                         $"Date and time the entry was added: {DateTimeEntryWasAdded}" +
                                         $"{Worker}\n";
}