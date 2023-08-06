using System.Threading.Channels;

namespace PracticalWork008;

public class MyHashSet
{
    private HashSet<int> userHashSet = new HashSet<int>();

    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            int number = UserInputInt("Введите число  -> ");
            if (userHashSet.Contains(number)) Console.WriteLine("Такое число уже есть ");
            else userHashSet.Add(number);
        }
    }

    public void PrintHashSet() => Console.Write(string.Join(" ", userHashSet));

    public  int UserInputInt(string message)
    {
        Console.Write($"{message} ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (isNumber) return result;
        throw new FormatException();
    }
}