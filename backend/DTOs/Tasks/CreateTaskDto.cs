using backend.Models;
using System.ComponentModel.DataAnnotations;

namespace backend.DTOs.Tasks
{
    public class CreateTaskDto
    {
        [Required]
        public string ProjectId { get; set; } = null!;
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Models.TaskStatus Status { get; set; } = Models.TaskStatus.Backlog;
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        public DateTime? DueDate { get; set; }
        public List<string> Labels { get; set; } = new();
        public List<string> ReporterIds { get; set; } = new();
        public List<string> AssigneeIds { get; set; } = new();
    }
}
