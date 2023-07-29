namespace PracticalWork002
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задача 1
            string fullNameUser = "Иванов Иван Иванович";
            byte ageUser = 27;
            string emailUser = @"pochta@gmail.com";
            float programmingPoints = 100f;
            float mathematicsPoints = 100f;
            float physicsPoints = 100f;

            Console.WriteLine($"ФИО: {fullNameUser}\n" +
                              $"Возраст: {ageUser}\n" +
                              $"Email: {emailUser}\n" +
                              $"Баллы по программированию: {programmingPoints}\n" +
                              $"Баллы по математике: {mathematicsPoints}\n" +
                              $"Баллы по физике: {physicsPoints}");
            Console.ReadKey();
            
            //Задача 2
            float sumAllPoints = programmingPoints + mathematicsPoints + physicsPoints;
            float averagePoint = sumAllPoints / 3;
            Console.WriteLine($"Сумма всех балов: {sumAllPoints}\n" +
                              $"Средний балл: {averagePoint}");
            Console.ReadKey();
        }
    }
}