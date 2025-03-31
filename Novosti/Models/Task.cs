namespace Models;

public class Task
{
    public bool IsDone { get; set; }
    public Status TaskStatus { get; set; }
    public string TaskName { get; set; }

    public Task(Status status, bool isDone, string taskName)
    {
        IsDone = isDone; 
        TaskStatus = status;
        TaskName = taskName;
    }


    public static object Delay(int i)
    {
        throw new NotImplementedException();
    }
}