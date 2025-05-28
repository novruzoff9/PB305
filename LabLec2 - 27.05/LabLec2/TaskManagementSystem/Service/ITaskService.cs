namespace TaskManagementSystem.Service;

public interface ITaskService
{
    void AddTask(Taskk task);
    Taskk FindTaskByTitle(string title);
    List<Taskk> TasksByStatus(string status);
    void RemoveById(string id);
}

public class TaskService : ITaskService
{
    List<Taskk> tasks = new();
    public void AddTask(Taskk task)
    {
        var check = tasks.FirstOrDefault(x => x.Title == task.Title);
        if (check == null)
        {
            tasks.Add(task);
        }
        else
        {
            throw new ConflictException("Bu adda task movcuddur");
        }
    }

    public Taskk FindTaskByTitle(string title)
    {
        var result = tasks.FirstOrDefault(x => x.Title == title);
        if (result == null)
        {
            throw new NotFoundException("Xeta bas verdi");
        }
        return result;
    }
    public List<Taskk> TasksByStatus(string status)
    {
        Enum.TryParse(status, true, out TaskStatuss resultStatus);

        var result = tasks.Where(x => x.Status == resultStatus).ToList();

        return result;
    }
    public void RemoveById(string id)
    {
        var result = tasks.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            throw new NotFoundException("tapilmadi");
        }
        else
        {
            tasks.Remove(result);
        }
    }
}
