using System;

namespace api.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Deleted { get; set; }
    }
}