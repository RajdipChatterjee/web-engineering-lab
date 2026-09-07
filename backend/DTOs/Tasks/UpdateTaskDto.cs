using backend.Models;

namespace backend.DTOs.Tasks
{
    public class UpdateTaskDto
    {
        public string? ProjectId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Models.TaskStatus? Status { get; set; }
        public TaskPriority? Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public List<string>? Labels { get; set; }
        public List<string>? ReporterIds { get; set; }
        public List<string>? AssigneeIds { get; set; }
    }
}
