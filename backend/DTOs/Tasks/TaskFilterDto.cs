using backend.Models;

namespace backend.DTOs.Task
{
    public class TaskFilterDto
    {
        public string? ProjectId { get; set; }
        public Models.TaskStatus? Status { get; set; }
        public TaskPriority? Priority { get; set; }
        public string? Search { get; set; }
    }
}