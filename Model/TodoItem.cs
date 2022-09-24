namespace ToDoApplication_RazorPages.Model
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateAndTime { get; set; }

        public string Priority { get; set; }

        public bool isDone { get; set; }
    }
}
