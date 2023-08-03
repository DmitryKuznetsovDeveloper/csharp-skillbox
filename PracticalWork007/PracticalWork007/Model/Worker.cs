using PracticalWork007.Interface;

namespace PracticalWork007;

public struct Worker : IWorker
{
    //Свойства класса 
    public string FullName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public DateTime BirthDay { get; set; }
    public string PlaceOfBirth { get; set; }

    /// <summary>
    /// Конструктор 
    /// </summary>
    /// <param name="fullName">ФИО</param>
    /// <param name="age">Возраст</param>
    /// <param name="height">Рост</param>
    /// <param name="birthDay">День рождения</param>
    /// <param name="placeOfBirth">Место рождения</param>
    public Worker()
    {
        Console.Write("Введите Полное ФИО -> ");
        FullName = Console.ReadLine();
        Console.Write("Введите Возраст -> ");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Рост -> "); 
        Height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите Дату рождения -> "); 
        BirthDay = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Введите место рождения -> "); 
        PlaceOfBirth = Console.ReadLine();
    }
    
    public Worker(string fullName, int age, double height, DateTime birthDay, string placeOfBirth)
    {
        FullName = fullName ;
        Age = age;
        Height = height;
        BirthDay = birthDay.Date;
        PlaceOfBirth = placeOfBirth;
    }
    

    /// <summary>
    /// Переопределенный метод вывода
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"\nFull Name: {FullName}\n" +
                                         $"Age: {Age}\n" +
                                         $"Height: {Height}\n" +
                                         $"BirthDay: {BirthDay.ToString("d")}\n" +
                                         $"PlaceOfBirth: {PlaceOfBirth}\n";
}