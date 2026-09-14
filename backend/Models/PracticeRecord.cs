using backend.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Models
{
    public abstract class PracticeRecord : RecordBase, IPracticeRecord
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string PracticeId { get; set; } = null!;
    }
}
