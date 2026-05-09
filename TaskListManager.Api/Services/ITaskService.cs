using TaskListManager.Api.Entities;

namespace TaskListManager.Api.Services
{
    public interface ITaskService
    {
        Task<MyTask?> AddTaskAsync(string name, string? description, int taskListId, int priority);
        Task<bool> DeleteTaskAsync(int taskId);
        Task<MyTask?> UpdateTaskAsync(int taskId, string? name, string? description, bool? isCompleted, int? priority);
    }
}