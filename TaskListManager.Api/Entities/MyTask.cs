namespace TaskListManager.Api.Entities
{
    public class MyTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null;    
        public bool IsCompleted { get; set; }
        public int Priority { get; set; }

        public int TaskListId { get; set; }
        public TaskList? TaskList { get; set; }

        protected MyTask() { }
        public MyTask(string name, string? description = null, bool isCompleted = false, int priority = 0, int taskListId = 0)
        {
            Name = name;
            Description = description;
            IsCompleted = isCompleted;
            Priority = priority;
            TaskListId = taskListId;
        }
    }
}