using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace _WebAPIMongoDB.Models
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
       // [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
       
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

    }
}
