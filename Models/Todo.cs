namespace CrdPractice.Models
{

    public class Todo
    {
        public int Id { get; set; }
        public string? TodoItem { get; set; }

        public bool IsCompleted { get; set; } = false;
    }

}