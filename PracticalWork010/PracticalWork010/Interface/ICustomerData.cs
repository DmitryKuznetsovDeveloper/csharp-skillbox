using System.Collections;

namespace PracticalWork010.Interface;

public interface ICustomerData
{
    public  string PathDirectoryWorkers { get; protected set; }
    public string PathFileWorkers { get; protected set; }
    /*public INote Note { get; protected set; }
    public IClient Client { get; protected set; }
    public IView View { get; protected set; }
    public List<INote> ListNotes { get; protected set; }
    public string ParsedFile { get; protected set; }*/
}