using System;

namespace api.Models
{
    public class TaskObj
    {
        public int Id { get; set; }
        public int TaskListId { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Deleted { get; set; }
    }
}