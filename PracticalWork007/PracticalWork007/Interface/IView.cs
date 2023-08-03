namespace PracticalWork007.Interface;

public interface IView
{
    public string Menu { get; set; }
    public string OpenFile { get; set; } 
    public string EmptyFile { get; set; } 
    public string InputUser { get; set; }
    public string InputUserId { get; set; }
    public string InputUserDate { get; set; }
    public string SuccessfullyAddedWorker { get; set; }
    public string SuccessfullyDelWorker { get; set; }
    public string ErrorId { get; set; }
}