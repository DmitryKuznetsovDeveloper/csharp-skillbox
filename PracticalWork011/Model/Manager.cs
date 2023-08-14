using System;
using System.Collections.Generic;
using System.IO;
using PracticalWork011.Interface;
using PracticalWork011.Model;

namespace PracticalWork011;

public class Manager : Consultant , IManager
{
    /// <summary>
    /// Вывод всек клиентов
    /// </summary>
    /// <param name="listNotes"></param>
    public override void PrintAllWorker(List<INote> listNotes)
    {
        Console.WriteLine(new string('=',100));
        foreach (var note in listNotes)
        {
            Console.WriteLine($"\nID: {note.Id}\n" +
                              $"Date Time Entry Was Added Change: {note.DateTimeEntryWasAdded}\n" + 
                              $"Who Made The Changes: {note.ChangeInfo}\n"+
                              $"\nSecondName: {note.Client.SecondName}\n" + 
                              $"Name: {note.Client.Name}\n" + 
                              $"Surname: {note.Client.Surname}\n" + 
                              $"Phone: {note.Client.Phone}\n" + 
                              $"Passport: {note.Client.Passport}");

            Console.WriteLine(new string('=',100));
        }
    }
    
    /// <summary>
    /// Записать в файл
    /// </summary>
    public override void AddedNoteClient(List<INote> ListNotes, string PathFileWorkers)
    {
        Note note = new Note();
        using (StreamWriter writer = new StreamWriter(PathFileWorkers,true))
        {
            writer.WriteLine($"{note.Id}#{note.DateTimeEntryWasAdded}#{note.Client.SecondName}#" +
                             $"{note.Client.Name}#{note.Client.Surname}#{note.Client.Phone}#" +
                             $"{note.Client.Passport}");
        }
        ListNotes.Add(note);
    }
}