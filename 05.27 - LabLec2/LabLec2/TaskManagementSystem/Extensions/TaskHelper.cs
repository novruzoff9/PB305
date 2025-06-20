namespace TaskManagementSystem.Extensions;

public static class TaskHelper
{
    public static TimeSpan TotalDuration(this Taskk task) => task.DeadLine - DateTime.Now;
    public static TimeSpan TimeDuration(this Taskk task) => task.DeadLine - task.Created;
}
