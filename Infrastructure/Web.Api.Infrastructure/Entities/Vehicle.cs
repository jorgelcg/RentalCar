using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace Web.Api.Infrastructure.Models
{
    public class Vehicle
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int32)]
        public Int32? Id { get; set; }
        
        [BsonElement("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; } = null!;

        [BsonElement("brand")]
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [BsonElement("color")]
        [JsonPropertyName("color")]
        public string Color { get; set; }

        [BsonElement("location")]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        [BsonElement("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        [BsonElement("cantDay")]
        [JsonPropertyName("cantDay")]
        public int CantDay { get; set; }

        [BsonElement("amount")]
        [JsonPropertyName("amount")]
        public int  Amount { get; set; }

        [BsonElement("iduser")]
        [JsonPropertyName("iduser")]
        public string Iduser { get; set; }

    }
}
