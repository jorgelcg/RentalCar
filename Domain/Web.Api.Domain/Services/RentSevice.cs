using MongoDB.Driver;
using Web.Api.Domain.Interfaces;
using Web.Api.Infrastructure.DBContext;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Services
{
    public class RentSevice : IRentInterface
    {
        private readonly MongoDBContext _context;
        public RentSevice(MongoDBContext context) {
            _context = context;
        }
        public async Task<IEnumerable<Vehicle>> GetLocationCar(string localidad)
        {
            var Location = await _context.Vehicle.Find(Localidad => Localidad.Location == localidad).FirstAsync();

            return (IEnumerable<Vehicle>)Location;
        }
    }
}