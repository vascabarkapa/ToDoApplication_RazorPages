using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApplication_RazorPages.Model;

namespace ToDoApplication_RazorPages.Pages.TodoItems
{
    public class CreateModel : PageModel
    {
        public TodoItem TodoItem { get; set; }

        public void OnGet()
        {
        }
    }
}
