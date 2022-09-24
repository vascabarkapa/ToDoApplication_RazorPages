using Microsoft.EntityFrameworkCore;
using ToDoApplication_RazorPages.Model;

namespace ToDoApplication_RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
