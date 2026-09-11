using backend.Interfaces;

namespace backend.Models
{
    public abstract class RecordBase<TId> : IRecord<TId> where TId : notnull
    {
        public TId Id { get; set; } = default!;
        public long AutoNumber { get; set; }
        public string? Number { get; set; }

        public OperationTypeDetail<TId> CreationInfo { get; set; } = default!;
        public OperationTypeDetail<TId>? UpdationInfo { get; set; }
        public OperationTypeDetail<TId>? DeletionInfo { get; set; }
    }

    public class OperationTypeDetail<TId>
    {
        public TId Author { get; set; } = default!;
        public DateTime TimeStamp { get; set; }
    }

    public enum OperationType
    {
        Unknown = 0,
        Create = 1,
        Update = 2,
        Delete = 3,
    }

    public enum RecordType
    {
        Unknown = 0,
        Task = 1,
        Project = 2,
        User = 3
    }

    public enum UserRole
    {
        Unknown = 0,
        Employee = 1,
        Manager = 2,
        Admin = 3
    }
}
