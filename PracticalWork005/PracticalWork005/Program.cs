namespace PracticalWork005
{
    internal class Program
    {
        public static string[] SplitText(string text, char separator) => text.Split(separator);

        public static string Reverse(string text)
        {
            string[] temp = SplitText(text, ' ');
            Array.Reverse(temp);
            return string.Join(" ", temp);
        }
        public static void Main(string[] args)
        {
            //Задание 1. Метод разделения строки на слова
            //Реализовал встроенными методами =)
            Console.Write("введите сообщение -> ");
            string userInputFirst = Console.ReadLine();
            Console.WriteLine(userInputFirst);
            string[] messageFirst = SplitText(userInputFirst,' ');
            Console.WriteLine(string.Join("\n", messageFirst));
            
            //Задание 2. Перестановка слов в предложении
            //Реализовал встроенными методами =)
            Console.Write("введите сообщение -> ");
            string userInputSecond = Console.ReadLine();
            Console.WriteLine(userInputSecond);
            Console.WriteLine(Reverse(userInputSecond));
        }
    }
}