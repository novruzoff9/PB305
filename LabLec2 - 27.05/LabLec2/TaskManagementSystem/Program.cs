namespace TaskManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taskk task = new Taskk
            {
                Title = "Task 1",
                Description = "This is the first task",
                DeadLine = DateTime.Now.AddDays(7),
                Status = TaskStatuss.ToDo,
            };
            Taskk task2 = new Taskk
            {
                Title = "Task 2",
                Description = "This is the second task",
                DeadLine = DateTime.Now.AddDays(5),
                Status = TaskStatuss.InProgress
            };
            Taskk task3 = new Taskk
            {
                Title = "Task 3",
                Description = "This is the third task",
                DeadLine = DateTime.Now.AddDays(3),
                Status = TaskStatuss.Done
            };
            Taskk taskk4 = new Taskk
            {
                Title = "Task 1",
                Description = "This is the fourth task",
                DeadLine = DateTime.Now.AddDays(2),
                Status = TaskStatuss.ToDo
            };
            Taskk task5 = new Taskk
            {
                Title = "Task 5",
                Description = "This is the fifth task",
                DeadLine = DateTime.Now.AddDays(1),
                Status = TaskStatuss.InProgress
            };

            var timeLeft = task2.TimeDuration();
            Console.WriteLine(timeLeft);
            
        }
    }
}
