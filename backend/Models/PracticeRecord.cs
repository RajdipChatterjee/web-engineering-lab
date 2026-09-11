namespace backend.Models
{
    public class PracticeRecord<TId> : RecordBase<TId> where TId : notnull
    {
        public int PracticeId { get; set; }
    }
}
