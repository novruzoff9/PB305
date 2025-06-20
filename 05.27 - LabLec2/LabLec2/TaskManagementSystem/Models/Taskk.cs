namespace TaskManagementSystem.Models;
public  class Taskk
{
    public string Id { get; set; }
    public string  Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; set; }
    public DateTime DeadLine { get; set; }
    public TaskStatuss Status { get; set; }
    public Taskk()
    {
        Id = Guid.NewGuid().ToString();
        Created = DateTime.Now;
    }
    public override string ToString()
    {
        return $"Id {Id} , Title {Title} , Description {Description}";
    }
}
