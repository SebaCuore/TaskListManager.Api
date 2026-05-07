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
    }
}
