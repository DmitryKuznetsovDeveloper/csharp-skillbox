using PracticalWork011.Interface;

namespace PracticalWork011;

public class View : IView
{
    public string Menu { get; set; } = new string('=', 50) + 
                                      "\n1: Вывести список всех работников\n" +
                                      "2: Изменить номер телефона\n" +
                                      "3: Поиск вывести работника по ID\n" + 
                                      "4: добавить клиента\n" + 
                                      "5: Выход\n" +
                                      new string('=', 50);
    
    public string OpenFile { get; set; } = new string('=', 50) +  "\nФайл успешно открыт\n" + new string('=', 50);
    public string EmptyFile { get; set; } = new string('=', 50) + "\nСписок работников пуст\n" + new string('=', 50);

    public string SuccessfullyAddedWorker { get; set; } = new string('=', 50) + "\nРаботник успешно добавлен\n" + new string('=', 50);
    
    public string SuccessfullyDelWorker { get; set; } = new string('=', 50) + "\nРаботник успешно удален\n" + new string('=', 50);
    public string InputUser { get; set; } = "Введите пункт меню -> ";
    public string InputUserId { get; set; } = "Введите ID работника -> ";
    public string InputUserIdPhone { get; set; } = "Введите ID работника чтобы изменить номер -> ";
    
    public string ErrorId { get; set; } = new string('=', 50) + "\nОшибка такого ID не существует\n" + new string('=', 50) ;

}