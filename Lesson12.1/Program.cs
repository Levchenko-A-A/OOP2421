TaskManager taskManager = new TaskManager();
taskManager.Add(new Task() { DueDate = DateTime.Parse("12.02.2024"), 
                             Prioity = Prioity.Medium, 
                             Title = "t1" });
taskManager.Add(new Event() { DueDate = DateTime.Parse("09.10.2024"), 
                              Location = "Konig", 
                              Prioity = Prioity.High, 
                              Title = "t2" });
taskManager.Print();
taskManager.Remove(taskManager.Tasks[1]);
taskManager.Print();
enum Prioity
{
    Low,
    Medium,
    High
};

class Task : ITask
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public void Display()
    {
        Console.WriteLine(Title+" "+DueDate+" "+Prioity);
    }
}

class Event : ITask
{
    public string? Title { get; set; }
    public string? Location { get; set; }
    public DateTime DueDate { get; set; }
    public Prioity Prioity { get; set; }

    public void Display()
    {
        Console.WriteLine(Title + " " + DueDate + " " + Prioity + " " + Location);
    }
}
class TaskManager
{
    public List<ITask> Tasks { get; set; } = new();

    public void Add(ITask task)
    { 
        Tasks.Add(task); 
    }
    public void Remove(ITask task) 
    { 
        Tasks.Remove(task); 
    }
    public void Print()
    {
        foreach(var item in Tasks)
            item.Display();
    }

}
interface ITask
{
    string Title { get; set; }
    DateTime DueDate { get; set; }
    Prioity Prioity { get; set; }
    void Display();
}