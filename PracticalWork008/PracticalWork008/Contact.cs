namespace PracticalWork008;

public class Contact
{
    public string FullName { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public int ApartmentNumber { get; set; }
    public string MobilePhone { get; set; }
    public string HomePhone { get; set; }
    public Contact()
    {
        Console.WriteLine("Введите полное имя");
        FullName = Console.ReadLine();
        Console.WriteLine("Введите улицу");
        Street = Console.ReadLine();
        Console.WriteLine("Введите номер дома");
        HouseNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер квартиры");
        ApartmentNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите мобильный телефон");
        MobilePhone = Console.ReadLine();
        Console.WriteLine("Введите домашний телефон");
        HomePhone = Console.ReadLine();
    }
}