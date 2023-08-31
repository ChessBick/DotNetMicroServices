using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace StudentAPI.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
