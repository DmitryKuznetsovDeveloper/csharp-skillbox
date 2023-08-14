using System.Collections.Generic;

namespace PracticalWork011.Interface;

public interface IManager 
{
    public void AddedNoteClient(List<INote> ListNotes, string PathFileWorkers);
}