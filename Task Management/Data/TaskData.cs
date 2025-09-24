using Microsoft.EntityFrameworkCore;
using Task_Management.Models;

namespace Task_Management.Data
{
        public class TaskData : DbContext
        {
            public TaskData(DbContextOptions<TaskData> options) : base(options)
            {
            }
            public DbSet<User> Users { get; set; }
            public DbSet<TaskItems> Tasks { get; set; }
        }
}
