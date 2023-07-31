namespace PracticalWork005
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1. Метод разделения строки на слова
            //Реализовал встроенными методами =)
            Console.Write("введите сообщение -> ");
            string userInputFirst = Console.ReadLine();
            Console.WriteLine(userInputFirst);
            string[] messageFirst = userInputFirst.Split();
            Console.WriteLine(string.Join("\n", messageFirst));
            
            //Задание 2. Перестановка слов в предложении
            //Реализовал встроенными методами =)
            Console.Write("введите сообщение -> ");
            string userInputSecond = Console.ReadLine();
            Console.WriteLine(userInputSecond);
            string[] messageSecond = userInputSecond.Split();
            Array.Reverse(messageSecond);
            Console.WriteLine(string.Join(" ", messageSecond));
        }
    }
}