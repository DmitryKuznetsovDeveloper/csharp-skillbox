namespace PracticalWork004;

public class MyMethods
{
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
    /// Создание пользовательской матирицы
    /// </summary>
    /// <param name="row">строки</param>
    /// <param name="col">колонки</param>
    /// <returns></returns>
    public static int[,] CreateMatrix(int row, int col) => new int[row, col];

    /// <summary>
    /// Заполнение матрицы рандомом
    /// </summary>
    /// <param name="matrix">матрица</param>
    public static void FillMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1, 11);
            }
        }
    }

    /// <summary>
    /// Вывод в консоль
    /// </summary>
    /// <param name="matrix">матрица</param>
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
    
    /// <summary>
    /// Сумма всех элементов матрицы
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static int SumMatrix(int[,] matrix)
    {
        int result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLongLength(1); j++)
            {
                result += matrix[i, j];
            }
        }

        return result;
    }
    
    /// <summary>
    /// Нахождение суммы двух матриц
    /// </summary>
    /// <param name="matrixFirst"></param>
    /// <param name="matrixSecond"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static int[,] MatrixSum(int[,] matrixFirst, int[,] matrixSecond)
    {
        if ((matrixFirst.GetLength(0) != matrixSecond.GetLength(0)) || (matrixFirst.GetLength(1) != matrixSecond.GetLength(1)))
        {
            throw new Exception("Для матриц с разным размером сложение не возможно!");
        }

        var matrixC = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

        for (var i = 0; i < matrixFirst.GetLength(0); i++)
        {
            for (var j = 0; j < matrixSecond.GetLength(1); j++)
            {
                matrixC[i, j] = matrixFirst[i, j] + matrixSecond[i, j];
            }
        }
        return matrixC;
    }
}