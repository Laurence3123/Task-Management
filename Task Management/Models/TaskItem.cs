namespace Task_Management.Models
{
    public class TaskItem
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public string? Priority { get; set; }

        public User user { get; set; }
    }
}
