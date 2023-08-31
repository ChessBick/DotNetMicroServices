using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace StudentAPI.Models
{
    public class Students
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
    }
}
