﻿namespace Task_Management.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public byte[] PasswordHash { get; set; }

        //Navigation
        public ICollection<TaskItems> Tasks { get; set; }
    }
}
