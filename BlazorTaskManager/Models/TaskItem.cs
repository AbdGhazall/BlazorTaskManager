using System.ComponentModel.DataAnnotations;

namespace BlazorTaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a priority")]
        public string Priority { get; set; } = string.Empty;

        public DateTime? DueDate { get; set; }

        public string Category { get; set; } = "Work";

        public bool IsCompleted { get; set; }

        public string? AttachedFileName { get; set; }
    }
}