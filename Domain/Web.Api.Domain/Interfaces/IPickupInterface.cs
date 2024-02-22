using Web.Api.Domain.Entities;
using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Interfaces
{
    public interface IPickupInterface
    {
        Task<IEnumerable<Vehicle>> PickUpService(PickupDTO pickup);
    }
}
