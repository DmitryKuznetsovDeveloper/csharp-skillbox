using System;

namespace PracticalWork011.Interface;

public interface INote
{
    public long Id { get; }
    public IClient Client { get; set; }
    public DateTime DateTimeEntryWasAdded { get; set; }
    public string ChangeInfo { get; set; }
}