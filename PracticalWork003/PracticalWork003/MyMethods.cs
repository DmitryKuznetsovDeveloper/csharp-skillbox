using System.Threading.Channels;

namespace PracticalWork003;

public static class MyMethods
{
    /// <summary>
    /// Проверка на четность
    /// </summary>
    /// <param name="number">число</param>
    /// <returns></returns>
    public static bool IsEven(int number) => number % 2 == 0;

    /// <summary>
    /// Метод получения числа от пользователя
    /// </summary>
    /// <param name="message">сообщение для пользователя</param>
    /// <returns></returns>
    /// <exception cref="FormatException">Ошибка, если пользователь ввел не число</exception>
    public static int UserInputInt(string message)
    {
        Console.Write($"{message}: ");
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        if (isNumber) return result;
        throw new FormatException();
    }

    /// <summary>
    /// Метод получения количество очков в зависимости от карты, от пользователя
    /// </summary>
    /// <param name="message">Сообщение для пользователя</param>
    /// <returns></returns>
    public static int UserInputCards(string message)
    {
        Console.Write($"{message}: ");
        string? userInput = Console.ReadLine();
        switch (userInput?.ToUpper())
        {
            case "K":
            case "Q":
            case "J":
            case "T":
                return 10;
            default:
                bool isNumber = int.TryParse(userInput, out int result);
                return result;
        }
    }

    /// <summary>
    /// Проверка числа на простое число
    /// </summary>
    /// <param name="number">число для проверки</param>
    /// <returns></returns>
    public static bool IsPrimeNumber(int number)
    {
        int count = 2;
        while (count < number)
        {
            if (number % count == 0) return false;
            
            count++;
        }

        return true;
    }

    /// <summary>
    /// Заполнение последовательности чисел пользователем
    /// </summary>
    /// <param name="array"></param>
    public static void FillOrderArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = UserInputInt($"Введите {i + 1} число в последовательности");
        }
    }
    
    /// <summary>
    /// Создание последовательности пользователем
    /// </summary>
    /// <returns></returns>
    public static int[] CreateOrderArray()
    {
        int lenght = UserInputInt($"Введите количество цифр в последовательности");
        int[] array = new int[lenght];
        return array;
    }

    /// <summary>
    /// Старт игры угадай число
    /// </summary>
    /// <param name="maxNumberOrder">максимальное число диапозона до которого будет выбираться рандомное значение</param>
    public static void GameStart(int maxNumberOrder)
    {
        int hiddenNumber = new Random().Next(0, maxNumberOrder + 1);
        Console.WriteLine("Я загадал число =)");
        while (true)
        {
            Console.WriteLine("Попробуй отгадать число -> ");
            string? userInput = Console.ReadLine();
            if (userInput == null)
            {
                Console.WriteLine($"Вы не отгадали число =(\nзагаданное число было {hiddenNumber}");
            }
            int result = Convert.ToInt32(userInput);
            if (result > hiddenNumber) Console.WriteLine("Ваше число больше загаданного");
            if (result < hiddenNumber) Console.WriteLine("Ваше число меньше загаданного");
            if (result == hiddenNumber)
            {
                Console.WriteLine("Вы отгадали число поздравляю !!!");
                return;
            }
            
            
        }
    }
}