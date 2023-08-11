namespace PracticalWork010.Interface;

public interface IView
{
    public string Menu { get; set; }
    public string EmptyFile { get; set; } 
    public string InputUser { get; set; }
    public string InputUserId { get; set; }
    public string InputUserIdPhone { get; set; }
    public string SuccessfullyAddedWorker { get; set; }

}