using Microsoft.EntityFrameworkCore;
using Task_Management.Models;

namespace Task_Management.Data
{
    public class TaskDbContext
    {
        public class DatabaseContext : DbContext
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {

            }
            public DbSet<User> Users { get; set; }
            public DbSet<TaskItem> Tasks { get; set; }
        }
    }
}
