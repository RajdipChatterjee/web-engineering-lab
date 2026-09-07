using backend.Models;

namespace backend.DTOs.Tasks
{
    public class TaskResponseDto
    {
        public string TaskId { get; set; } = null!;
        public string ProjectId { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Models.TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public List<string> Labels { get; set; } = new();
        public List<string> ReporterIds { get; set; } = new();
        public List<string> AssigneeIds { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
