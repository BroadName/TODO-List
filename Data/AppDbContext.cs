using Microsoft.EntityFrameworkCore;
using TodoAppMVC.Models;

namespace TodoAppMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
