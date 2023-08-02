using PracticalWork006.Interface;

namespace PracticalWork006;

public class ControllerNotebook : INotebook
{
    public string PathDirectoryWorkers { get; set; } = @"C:\Workers";
    public string PathFileWorkers { get; set; } = @"C:\Workers\Workers.txt";
    public INote INote { get; set; }
    public IWorker IWorker { get; set; }
    public List<INote> ListNotes { get; set; }
    public string ParsedFile { get; set; }

    #region Вспомогательные методы для работы класса

        /// <summary>
        /// Проверка существования нужной директории в диске С, в случае если такой директории нет, метод ее создаст
        /// </summary>
        private void CheckPathDirectoryWorkers()
        {
            if (!Directory.Exists(PathDirectoryWorkers)) 
                Directory.CreateDirectory(PathDirectoryWorkers);
        }
        
        /// <summary>
        /// Проверка существования нужного файла в диске С, в случае если такого файла нет, метод его создаст
        /// </summary>
        private void CheckPathFileWorkers()
        {
            if (!File.Exists(PathFileWorkers)) 
                File.Create(PathFileWorkers);
        }
        
        /// <summary>
        /// Чтение файла
        /// </summary>
        private string ReadFile()
        {
            using (StreamReader reader = new  StreamReader(PathFileWorkers))
            {
                string resultFile = "";
                while (!reader.EndOfStream)
                {
                    resultFile = reader.ReadToEnd();
                }
                return resultFile;
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
                    Note note = new Note(Convert.ToInt64(temp[0]), Convert.ToDateTime(temp[1]), new Worker(temp[2],
                        Convert.ToInt32(temp[3]), Convert.ToDouble(temp[4]), 
                        Convert.ToDateTime(temp[5]), temp[6]));
                    ListNotes.Add(note);
                }
            }
        }
        

    #endregion
    

    /// <summary>
    /// Конструктор с проверками 
    /// </summary>
    public ControllerNotebook()
    {
        ListNotes = new List<INote>();
        CheckPathDirectoryWorkers();
        CheckPathFileWorkers();
        ParsedFile = ReadFile();
        FillListFromFile();
    }

    #region Различные методы для работы 
    /// <summary>
    /// Записать в файл
    /// </summary>
    public void AddedNoteWorker()
    {
        using (StreamWriter writer = new StreamWriter(PathFileWorkers,true))
        {
            INote note = new Note();
            writer.WriteLine($"{note.Id}#{note.DateTimeEntryWasAdded}#{note.Worker.FullName}#" +
                             $"{note.Worker.Age}#{note.Worker.Height}#{note.Worker.BirthDay}#" +
                             $"{note.Worker.PlaceOfBirth}");
            ListNotes.Add(note);
        }
    }

    /// <summary>
    /// Вывод на печать всех сотрудников
    /// </summary>
    public void PrintAllWorker()
    {
        Console.WriteLine(new string('=',100));
        foreach (var note in ListNotes)
        {
            Console.WriteLine($"{note}");
        }
        Console.WriteLine(new string('=',100));
    }

    

    #endregion
}