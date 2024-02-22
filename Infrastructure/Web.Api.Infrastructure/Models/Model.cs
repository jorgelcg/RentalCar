
namespace Web.Api.Infrastructure.Models
{
    public class MongoDBSettings
    {
        public string VehicleCollectionName { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}
