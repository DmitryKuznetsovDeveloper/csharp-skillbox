using System;
using System.Collections.Generic;
using System.IO;
using PracticalWork011.Interface;

namespace PracticalWork011;

public class CustomerData : ICustomerData
{
    //Свойства класса
    public string PathDirectoryWorkers { get; set; } = @"C:\Workers";
    public string PathFileWorkers { get; set; } = @"C:\Workers\Workers.txt";
    public List<INote> ListNotes { get; set; }
    public string ParsedFile { get; set; }

    #region Вспомогательные методы для работы класса

    /// <summary>
    /// Проверка существования нужной директории в диске С, в случае если такой директории нет, метод ее создаст
    /// </summary>
    private void CheckPathDirectoryWorkers()
    {
        if (!Directory.Exists(PathDirectoryWorkers)) Directory.CreateDirectory(PathDirectoryWorkers);
    }

    /// <summary>
    /// Проверка существования нужного файла в диске С, в случае если такого файла нет, метод его создаст
    /// </summary>
    private void CheckPathFileWorkers()
    {

        if (!File.Exists(PathFileWorkers))
        {
            using (FileStream fileStream = new FileStream(PathFileWorkers,FileMode.Create))
            {
                
            }
        }
        else
        {
            ReadFile();
            FillListFromFile();
        }
    }

    /// <summary>
    /// Чтение файла
    /// </summary>
    private void ReadFile()
    {
        using (StreamReader reader = new StreamReader(PathFileWorkers))
        {
            string resultFile = "";
            while (!reader.EndOfStream)
            {
                resultFile = reader.ReadToEnd();
            }
            ParsedFile = resultFile;
        }
    }

    /// <summary>
    /// Заполнение информации в лист из прочитаного файла
    /// </summary>
    private void FillListFromFile()
    {
        string[] tempData = ParsedFile.Split("\n");
        for (int i = 0; i < tempData.Length; i++)
        {
            string[] temp = tempData[i].Split("#");
            if (tempData[i] != String.Empty)
            {
                Note note = new Note(Convert.ToInt64(temp[0]), Convert.ToDateTime(temp[1]), new Client(temp[2],
                    temp[3], temp[4],temp[5], temp[6]), temp[7]);
                ListNotes.Add(note);
            }
        }
    }

    /// <summary>
    /// Обновление исходного файла, к примеру при удалении из программы сотрудника
    /// </summary>
    public void UpdateFile()
    {
        using (StreamWriter writer = new StreamWriter(PathFileWorkers))
        {
            for (int i = 0; i < ListNotes.Count; i++)
            {
                writer.WriteLine($"{ListNotes[i].Id}#{ListNotes[i].DateTimeEntryWasAdded}#{ListNotes[i].Client.SecondName}#" +
                                 $"{ListNotes[i].Client.Name}#{ListNotes[i].Client.Surname}#{ListNotes[i].Client.Phone}#" +
                                 $"{ListNotes[i].Client.Passport}#{ListNotes[i].ChangeInfo}");
            }
        }
    }
    #endregion
    
    /// <summary>
    /// Конструктор с проверками 
    /// </summary>
    public CustomerData()
    {
        ListNotes = new List<INote>();
        CheckPathDirectoryWorkers();
        CheckPathFileWorkers();
    }
}