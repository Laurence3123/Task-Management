﻿namespace Task_Management.Models
{
    public class TaskItems
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

        //Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
