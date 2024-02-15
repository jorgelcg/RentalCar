
using Web.Api.Domain.Interfaces;
using Web.Api.Infrastructure.DBContext;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Services
{
    public class PickupService : IPickupInterface
    {
        private readonly MongoDBContext _context;
        public IEnumerable<Vehicle> _;

        public PickupService(MongoDBContext mongoDBContext) {
            _context = mongoDBContext;
        }
        public Task<IEnumerable<Vehicle>> PickUpService(Vehicle pickup)
        {
            _ = (IEnumerable<Vehicle>)_context.Vehicle.InsertOneAsync(pickup);

            return (Task<IEnumerable<Vehicle>>)_;
        }
    }
}
