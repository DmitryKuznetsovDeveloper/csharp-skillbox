namespace PracticalWork008;

public static class ExtensionList
{
    /// <summary>
    /// Метод расширения, заполнения случайными числами от 0 до 100
    /// </summary>
    /// <param name="list"></param>
    public static void FillListRandomInt(this List<int> list)
    {
        for (int i = 0; i < 100; i++) list.Add(new Random().Next(0,101));
    }

    /// <summary>
    /// Метод расширения, вывода в консоль
    /// </summary>
    /// <param name="list"></param>
    public static void PrintList(this List<int> list)
    {
        int count = 0;
        foreach (var VARIABLE in list)
        {
            Console.Write($"{VARIABLE}\t");
            count++;
            if (count == 20)
            {
                Console.WriteLine();
                count = 0;
            }
        }
    }
    
    /// <summary>
    /// Метод расширения,Удаления из листа числес, которые больше 25, но меньше 50. 
    /// </summary>
    /// <param name="list"></param>
    public static void DelNumberSort(this List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > 25 && list[i] < 50) list.Remove(list[i]);
        }
    }
}