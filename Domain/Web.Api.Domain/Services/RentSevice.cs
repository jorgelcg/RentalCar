using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Web.Api.Domain.Entities;
using Web.Api.Domain.Interfaces;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Services
{
    public class RentSevice : IRentInterface
       { 
        private readonly IMongoCollection<Vehicle> _vehicleCollection;
        public RentSevice(IOptions<MongoDBSettings> mongodbsettings) {
            var mongoClient = new MongoClient(
            mongodbsettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                mongodbsettings.Value.DatabaseName);

            _vehicleCollection = mongoDatabase.GetCollection<Vehicle>(
                mongodbsettings.Value.VehicleCollectionName);
        }
        public async Task<Vehicle> GetLocationCar(string localidad)
        {
           var  Location =  await _vehicleCollection.Find(Localidad => Localidad.Location == localidad).FirstOrDefaultAsync();

            return Location;
        }
        //retornar la confirmacion del pickup
        //public Task<ResponseDTO> PickUpService(PickupDTO pickup)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IActionResult> DeliverService(string userID)
        //{
        //    _ = (IEnumerable<Vehicle>)_context.Vehicle.InsertOne(userID);

        //    return (Task<IEnumerable<Vehicle>>)_;
        //}
    }
}