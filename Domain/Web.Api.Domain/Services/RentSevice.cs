using Microsoft.Extensions.Options;
using MongoDB.Driver;
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
        //getting vehicles by location user.
        //example: suba
        public async Task<Vehicle> GetLocationCar(string localidad)
        {
           var  Location =  await _vehicleCollection.Find(Localidad => Localidad.Location == localidad).FirstOrDefaultAsync();

            return Location;
        }
        //orderind de service by IdVehicle, cant days, IdUser.
        //retur object with data seted.
        public async Task<Vehicle> PickUpService(int IdVehicle, int cantidadays,string IdUser)
        {
            var GetVehicle = await _vehicleCollection.Find(x => x.Id == IdVehicle).FirstOrDefaultAsync();

            int amount = (cantidadays * 100000);

            GetVehicle.Id = IdVehicle;
            GetVehicle.CantDay = cantidadays;
            GetVehicle.Amount = amount;
            GetVehicle.State = "reservado";
            GetVehicle.Iduser = IdUser;

            await _vehicleCollection.ReplaceOneAsync(GetVehicle => GetVehicle.Id == IdVehicle, GetVehicle);
            return GetVehicle;
        }
        //update de service giving IdVehicle to deliver and retur data... 
        public async Task<Vehicle> DeliverService(int IdVehicle)
        {
            var GetVehicle = await _vehicleCollection.Find(x => x.Id == IdVehicle).FirstOrDefaultAsync();
            GetVehicle.Id = IdVehicle;
            GetVehicle.CantDay = 0;
            GetVehicle.Amount = 0;
            GetVehicle.State = "disponible";
            GetVehicle.Iduser = "";
            var _ = await _vehicleCollection.ReplaceOneAsync(x => x.Id == IdVehicle, GetVehicle);

            return GetVehicle;
        }
    }
}