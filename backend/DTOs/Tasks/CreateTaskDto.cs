using backend.Models;

namespace backend.DTOs.Task
{
    public class CreateTaskDto
    {
        public string ProjectId { get; set; } = null!;
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