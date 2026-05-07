using Microsoft.EntityFrameworkCore;
using TaskListManager.Api.Entities;

namespace TaskListManager.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<MyTask> Tasks { get; set; }
    }
}
