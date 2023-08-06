using System.Xml.Serialization;

namespace  PracticalWork008;

internal class Program
{
    public static void Main(string[] args)
    {
        // Задание 1. Работа с листом с применением методов расширения.
        List<int> list = new List<int>();
        list.FillListRandomInt();
        list.PrintList();
        Console.WriteLine("\n");
        list.DelNumberSort();
        list.PrintList();

        Console.WriteLine();
        Console.WriteLine(new string('=',50));
        
        //Задание 2. Телефонная книга
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.Start();
        phoneBook.PrintPhoneBook();
        
        Console.WriteLine();
        Console.WriteLine(new string('=',50));
        
        //Задание 3. Проверка повторов
        MyHashSet myHashSet = new MyHashSet();
        try
        {
            myHashSet.Start();
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода");
        }
        myHashSet.PrintHashSet();
        
        Console.WriteLine();
        Console.WriteLine(new string('=',50));
        
        //Задание 4 Записная книжка. 
        Contact contact = new Contact("Иванов Иван Иваныч","Улица",23,12,
            "8999887754","495778877");
        MyXml myXml = new MyXml();
        myXml.SerializeContact(contact,"_contact.xml");
    }
}