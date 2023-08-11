using PracticalWork010.Interface;

namespace PracticalWork010;

public class Client : IClient
{
    //Свойства класса 
    public string SecondName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Passport { get; set; }

    /// <summary>
    /// Конструктор 
    /// </summary>
    public Client()
    {
        Console.Write("Введите Фамилию -> ");
        SecondName = Console.ReadLine();
        Console.Write("Введите Имя -> ");
        Name = Console.ReadLine();
        Console.Write("Введите Отчество -> "); 
        Surname = Console.ReadLine();
        Console.Write("Введите Телефон -> "); 
        Phone =Console.ReadLine();
        Console.Write("Введите Паспорт серию номер -> "); 
        Passport = Console.ReadLine();
    }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="secondName"></param>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    /// <param name="phone"></param>
    /// <param name="passport"></param>
    public Client(string secondName, string name, string surname, string phone, string passport)
    {
        SecondName = secondName ;
        Name = name;
        Surname = surname;
        Phone = phone;
        Passport = passport;
    }
    
    /// <summary>
    /// Переопределенный метод вывода
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"\nSecondName: {SecondName}\n" +
                                         $"Name: {Name}\n" +
                                         $"Surname: {Surname}\n" +
                                         $"Phone: {Phone}\n" +
                                         $"Passport: {Passport}\n";
}