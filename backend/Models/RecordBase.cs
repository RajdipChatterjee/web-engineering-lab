using backend.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models
{
    public abstract class RecordBase : IRecord
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = null!;
        public long AutoNumber { get; set; }
        public string? Number { get; set; }

        public AuditInfo AuditInfo { get; set; } = null!;
    }

    public class AuditInfo
    {
        public OperationInfo Created { get; set; } = null!;
        public OperationInfo? Updated { get; set; }
        public OperationInfo? Deleted { get; set; }
    }

    public class OperationInfo
    {
        public string Author { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public string? Description { get; set; }

        private OperationInfo() { }

        public static OperationInfo Create(string author, string? description = null)
        {
            return new OperationInfo
            {
                Author = author,
                Timestamp = DateTime.UtcNow,
                Description = description
            };
        }
    }
}