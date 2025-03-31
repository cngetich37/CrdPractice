using CrdPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace CrdPractice.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}