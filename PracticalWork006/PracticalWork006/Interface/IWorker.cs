namespace PracticalWork006.Interface;

public interface IWorker
{
    public string FullName { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public DateTime BirthDay { get; set; }
    public string PlaceOfBirth { get; set; }
}