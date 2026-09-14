using backend.Models;

namespace backend.Interfaces
{
    /// <summary>
    /// Defines the common contract for all records.
    /// </summary>
    public interface IRecord
    {
        string Id { get; set; }
        long AutoNumber { get; set; }
        string? Number { get; set; }
        AuditInfo AuditInfo { get; set; }
    }
}