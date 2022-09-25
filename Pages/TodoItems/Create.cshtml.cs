using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApplication_RazorPages.Data;
using ToDoApplication_RazorPages.Model;

namespace ToDoApplication_RazorPages.Pages.TodoItems
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public TodoItem TodoItem { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(TodoItem todoItem)
        {
            await _db.TodoItems.AddAsync(todoItem);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
