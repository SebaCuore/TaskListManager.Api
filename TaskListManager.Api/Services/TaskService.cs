using Microsoft.EntityFrameworkCore;
using TaskListManager.Api.Data;
using TaskListManager.Api.Entities;

namespace TaskListManager.Api.Services
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<MyTask?> AddTaskAsync(string name, string? description, int taskListId, int priority)
        {
            bool existList = await _context.TaskLists.AnyAsync(l => l.Id == taskListId);
            if (!existList)
            {
                return null;
            }
            var nuevaTarea = new MyTask(name, description, false, priority, taskListId);
            _context.Tasks.Add(nuevaTarea);
            await _context.SaveChangesAsync();
            return nuevaTarea;
        }

        public async Task<bool> DeleteTaskAsync(int taskId)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task == null)
            {
                return false;
            }
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<MyTask?> UpdateTaskAsync(int taskId, string? name, string? description, bool? isCompleted, int? priority)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task == null)
            {
                return null;
            }
            if (!string.IsNullOrEmpty(name))
            {
                task.Name = name;
            }
            if (description != null)
            {
                task.Description = description;
            }
            if (isCompleted.HasValue)
            {
                task.IsCompleted = isCompleted.Value;
            }
            if (priority.HasValue)
            {
                task.Priority = priority.Value;
            }
            await _context.SaveChangesAsync();
            return task;
        }
    }
}