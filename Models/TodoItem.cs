using System.ComponentModel.DataAnnotations;

namespace TodoAppMVC.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}
