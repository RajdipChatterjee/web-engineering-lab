using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace backend.Models
{
    [BsonIgnoreExtraElements]
    public class Task
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string TaskId { get; set; } = null!;
        [BsonElement("projectId")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProjectId { get; set; } = null!;
        [BsonElement("title")]
        public string Title { get; set; } = null!;
        [BsonElement("description"), BsonIgnoreIfNull]
        public string? Description { get; set; }
        [BsonElement("status"), BsonRepresentation(BsonType.Int32)]
        public TaskStatus Status { get; set; } = TaskStatus.Backlog;
        [BsonElement("priority"), BsonRepresentation(BsonType.Int32)]
        public TaskPriority Priority { get; set; } = TaskPriority.Medium;
        [BsonElement("dueDate"), BsonDateTimeOptions(Kind = DateTimeKind.Utc), BsonIgnoreIfNull]
        public DateTime? DueDate { get; set; }
        [BsonElement("labels")]
        public List<string> Labels { get; set; } = new();
        [BsonElement("reporterIds"), BsonRepresentation(BsonType.ObjectId)]
        public List<string> ReporterIds { get; set; } = new();
        [BsonElement("assigneeIds"), BsonRepresentation(BsonType.ObjectId)]
        public List<string> AssigneeIds { get; set; } = new();
        [BsonElement("createdAt"), BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [BsonElement("updatedAt"), BsonDateTimeOptions(Kind = DateTimeKind.Utc), BsonIgnoreIfNull]
        public DateTime? UpdatedAt { get; set; }
        [BsonElement("deletedAt"), BsonDateTimeOptions(Kind = DateTimeKind.Utc), BsonIgnoreIfNull]
        public DateTime? DeletedAt { get; set; }
    }

    public enum TaskStatus
    {
        [Description("Task is in the backlog")]
        Backlog = 1,
        [Description("Task is to do")]
        Todo = 2,
        [Description("Task is in progress")]
        InProgress = 3,
        [Description("Task is developed")]
        Developed = 4,
        [Description("Task is done")]
        Done = 5
    }

    public enum TaskPriority
    {
        [Description("Task is low priority")]
        Low = 1,
        [Description("Task is medium priority")]
        Medium = 2,
        [Description("Task is high priority")]
        High = 3,
        [Description("Task is urgent priority")]
        Urgent = 4,
        [Description("Task is critical priority")]
        Critical = 5
    }
}
