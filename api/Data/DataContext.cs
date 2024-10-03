using api.Models;
using Microsoft.EntityFrameworkCore;

namespace task_manager
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<TaskList> TaskLists { get; set; }
        public DbSet<TaskObj> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskList>().ToTable("TaskLists");
            modelBuilder.Entity<TaskObj>().ToTable("Tasks");
        }
    }
    
}