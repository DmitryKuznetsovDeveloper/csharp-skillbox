namespace PracticalWork004
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1. Случайная матрица
            try
            {
                int row = MyMethods.UserInputInt("введите количество строк");
                int col = MyMethods.UserInputInt("Введите количество колонок");
                int[,] userMatrix = MyMethods.CreateMatrix(row, col);
                MyMethods.FillMatrix(userMatrix);
                MyMethods.PrintMatrix(userMatrix);
                Console.WriteLine($"Сумма всех элементов матрицы: {MyMethods.SumMatrix(userMatrix)}");
                
                Console.WriteLine(new string('=', 50));
                
                //Задание 2. Сложение матриц
                int rowFirst = row;
                int colSecond = col;
                int[,] userMatrixSecond = MyMethods.CreateMatrix(row, col);
                MyMethods.FillMatrix(userMatrixSecond);
                Console.WriteLine("\nМатрица 1 ");
                MyMethods.PrintMatrix(userMatrix);
                Console.WriteLine("\nМатрица 2 ");
                MyMethods.PrintMatrix(userMatrixSecond);
                int[,] sumMatrix = MyMethods.MatrixSum(userMatrix, userMatrixSecond);
                Console.WriteLine("\nСумма матриц: ");
                MyMethods.PrintMatrix(sumMatrix);
            }
            catch (FormatException )
            {
                Console.WriteLine("Вы ввели не число");
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

