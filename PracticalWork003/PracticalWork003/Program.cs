namespace PracticalWork003
{ 
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1. Приложение по определению чётного или нечётного числа
            try
            {
                int userNumber = MyMethods.UserInputInt("Введите число для проверки его на четность");
                Console.WriteLine(MyMethods.IsEven(userNumber) 
                    ? $"Число {userNumber}: четное" 
                    : $"Число {userNumber}: не четное");
                Console.WriteLine(new string('=',50));
                Console.ReadKey();

            //Задание 2. Программа подсчёта суммы карт в игре «21»
            int numberCards = MyMethods.UserInputInt("Привет  пользователь, сколько у вас карт на руках ?");
            int sumCardsPoints = 0;
            for (int i = 0; i < numberCards; i++) 
            { 
                int temp = MyMethods.UserInputCards($"Введите номинал карты {i + 1}."); 
                sumCardsPoints += temp;
            } 
            Console.WriteLine($"Сумма ваших карт: {sumCardsPoints}");
            Console.WriteLine(new string('=',50));
            Console.ReadKey();

            //Задание 3. Проверка простого числа
            int userPrimeNumber = MyMethods.UserInputInt("Введите число для того чтобы проверить простое оно или нет");
            Console.WriteLine(MyMethods.IsPrimeNumber(userPrimeNumber) ? "Число простое" : "Число не простое");
            Console.WriteLine(new string('=',50));
            Console.ReadKey();

            //Задание 4. Наименьший элемент в последовательности
            int[] userOrder = MyMethods.CreateOrderArray(); 
            MyMethods.FillOrderArray(userOrder); 
            Console.WriteLine($"Минимально число из последовательности: {userOrder.Min()}");
            Console.WriteLine(new string('=',50));
            Console.ReadKey(); 
            
            //Задание 5. Игра «Угадай число»
            int userMaxNumberGame = MyMethods.UserInputInt("Введите максимальное число из диапозона от 0");
            MyMethods.GameStart(userMaxNumberGame);
            Console.WriteLine(new string('=',50));
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Error: вы ввели не число");
            }
        }
    }
}

