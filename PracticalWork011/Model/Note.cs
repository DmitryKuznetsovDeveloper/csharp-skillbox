using System;
using PracticalWork011.Interface;

namespace PracticalWork011;

public class Note : INote
{
    public long Id { get; set; }
    public DateTime DateTimeEntryWasAdded { get; set; }
    public IClient Client { get; set; }
    public string ChangeInfo { get; set; }
    
    public Note()
    {
        Console.Write("Введите ID -> "); 
        Id = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите кто вносит изменения в файл -> ");
        ChangeInfo = Console.ReadLine();
        Client = new Client();
        DateTimeEntryWasAdded = DateTime.Now;
    }
    
    public Note(long id,DateTime dateTimeEntryWasAdded, Client client, string changeInfo )
    {
        Id = id;
        Client = client;
        DateTimeEntryWasAdded = dateTimeEntryWasAdded;
        ChangeInfo =  changeInfo;
    }
/*
    public override string ToString() => $"\nID: {Id}\n" +
                                         $"Date and time the entry was added: {DateTimeEntryWasAdded.ToString("g")}" +
                                         $"Кто внес изменения: {ChangeInfo}" + 
                                         $"{Client}\n";*/
}