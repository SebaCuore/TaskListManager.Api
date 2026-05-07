namespace TaskListManager.Api.Entities
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } = null;
        public List<MyTask> Tasks { get; set; } = new List<MyTask>();
    }
}
