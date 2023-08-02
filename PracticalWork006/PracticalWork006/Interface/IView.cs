namespace PracticalWork006.Interface;

public interface IView
{
    public string Menu { get; set; }
    public string OpenFile { get; set; } 
    public string EmptyFile { get; set; } 
    public string InputUSer { get; set; }
    public string SuccessfullyAddedWorker { get; set; }
}