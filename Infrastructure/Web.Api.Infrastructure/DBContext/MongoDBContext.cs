
using MongoDB.Driver;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Infrastructure.DBContext
{
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Vehicle> Vehicle => _database.GetCollection<Vehicle>("Vehicle");

        public IMongoCollection<Vehicle> Pickup  => _database.GetCollection<Vehicle>("Pickup");
    }
}
