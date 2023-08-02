using System.Collections;

namespace PracticalWork006.Interface;

public interface INotebook
{
    public  string PathDirectoryWorkers { get; protected set; }
    public string PathFileWorkers { get; protected set; }
    public INote Note { get; protected set; }
    public IWorker Worker { get; protected set; }
    public IView View { get; protected set; }
    public List<INote> ListNotes { get; protected set; }
    public string ParsedFile { get; protected set; }
}