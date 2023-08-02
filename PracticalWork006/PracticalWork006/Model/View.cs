using PracticalWork006.Interface;

namespace PracticalWork006;

public class View : IView
{
    public string Menu { get; set; } = new string('=', 50) + 
                                      "\n1: Вывести список всех работников\n" +
                                      "2: Добавить нового работника в список\n" +
                                      "3: Выход\n" +
                                      new string('=', 50);

    public string OpenFile { get; set; } = new string('=', 50) +  "\nФайл успешно открыт\n" + new string('=', 50);
    public string EmptyFile { get; set; } = new string('=', 50) + "\nСписок работников пуст\n" + new string('=', 50);

    public string SuccessfullyAddedWorker { get; set; } = new string('=', 50) + "\nРаботник успешно добавлен\n" + new string('=', 50);
    public string InputUSer { get; set; } = "Введите пункт меню -> ";

}