
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Interfaces
{
    public interface IPickupInterface
    {
        Task<IEnumerable<Vehicle>> PickUpService(Vehicle pickup);
    }
}
