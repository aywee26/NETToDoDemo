using Microsoft.EntityFrameworkCore;
using NETToDoDemo.Entities;

namespace NETToDoDemo.Contexts
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
