using backend.Models;

namespace backend.Interfaces
{
    /// <summary>
    /// Defines the common contract for all records.
    /// </summary>
    public interface IRecord<TId> where TId : notnull
    {
        TId Id { get; set; }
        long AutoNumber { get; set; }
        string? Number { get; set; }
        OperationTypeDetail<TId> CreationInfo { get; set; }
        OperationTypeDetail<TId>? UpdationInfo { get; set; }
        OperationTypeDetail<TId>? DeletionInfo { get; set; }
    }
}