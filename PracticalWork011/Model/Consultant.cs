using System;
using System.Collections.Generic;
using System.Linq;
using PracticalWork011.Interface;

namespace PracticalWork011.Model;

public class Consultant : IConsultant
{
    /// <summary>
    /// Вывод всек клиентов
    /// </summary>
    /// <param name="listNotes"></param>
    public virtual void PrintAllWorker(List<INote> listNotes)
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
                              $"Passport: «******************»");

            Console.WriteLine(new string('=',100));
        }
    }
    
    /// <summary>
    /// Поиск клиента по ID записки
    /// </summary>
    /// <param name="id">ID записки</param>
    /// <returns>записку</returns>
    public INote GetWorkerById(List<INote> listNotes,long id) => listNotes.FirstOrDefault(x => x.Id == id);

    /// <summary>
    /// Изменение номера телефона
    /// </summary>
    /// <param name="client"></param>
    public void ChangeCustomerPhoneNumber(INote client)
    {
        while (true)
        {
            Console.Write("Введите новый номер телефона -> ");
            string result = Console.ReadLine();
            if (result != string.Empty)
            {
                Console.WriteLine();
                Console.Write("Введите кто вносит изменения в файл -> ");
                client.DateTimeEntryWasAdded = DateTime.Now;
                client.ChangeInfo = Console.ReadLine();
                client.Client.Phone = result;
                return;
            }
        }
        
    }

    public virtual void AddedNoteClient(List<INote> customerDataListNotes, string customerDataPathFileWorkers)
    {
        Console.WriteLine(new string('=',50)+"\nУ вас нет доступа для этой операции\n"+ new string('=',50));
    }
}