
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Web.Api.Infrastructure.Models
{
    public class Vehicle
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        
        [BsonElement("Type")]
        public string Type { get; set; }

        [BsonElement("Brand")]
        public string Brand { get; set; }

        [BsonElement("Color")]
        public string Color { get; set; }

        [BsonElement("Reference")]
        public string Reference { get; set; }

        [BsonElement("Location")]
        public string Location { get; set; }

        [BsonElement("Dateini")]
        public string Dateini { get; set; }

        [BsonElement("Datend")]
        public string Datend { get; set; }

        [BsonElement("State")]
        public int State { get; set; }


    }
}
