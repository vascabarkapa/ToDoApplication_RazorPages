using System.ComponentModel.DataAnnotations;

namespace ToDoApplication_RazorPages.Model
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateAndTime { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
        public bool isDone { get; set; }
    }
}
