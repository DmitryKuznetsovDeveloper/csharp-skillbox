namespace PracticalWork008;

public class PhoneBook
{
    private Dictionary<List<string>, string> userBook = new Dictionary<List<string>, string>();

    public void Start()
    {
        while (true)
        {
            Console.Write("Введите ФИО владельца -> ");
            string? fullName = Console.ReadLine();
            if (fullName == String.Empty) break;
            Console.Write("Введите номер телефона владельца -> ");
            string? phoneUser = Console.ReadLine();
            if (!userBook.ContainsValue(fullName))
            {
                List<string> phone = new List<string>();
                phone.Add(phoneUser);
                userBook.Add(phone, fullName);
            }
            if (userBook.ContainsValue(fullName))
            {
                foreach (var user in userBook) 
                    if (user.Value == fullName) user.Key.Add(phoneUser);
            }
        }
    }

    public void PrintPhoneBook()
    {
        foreach (var user in userBook)
        {
            Console.Write($"ФИО: {user.Value}:  ");
            foreach (var phone in user.Key)
            {
                Console.Write($"Телефон(ы): {phone}, ");
            }

            Console.WriteLine();
        }
    }
    
}