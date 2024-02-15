
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Web.Api.Infrastructure.Models
{
    public class Vehicles
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        [BsonElement("Tipevehicle")]
        public string Tipevehicle { get; set; }

        [BsonElement("Dateini")]
        public string Dateini { get; set; }

        [BsonElement("Datend")]
        public string Datend { get; set; }

        [BsonElement("LocationPick")]
        public string LocationPick { get; set; }
    }
}
