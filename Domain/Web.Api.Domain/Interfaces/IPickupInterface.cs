using Web.Api.Domain.Entities;

namespace Web.Api.Domain.Interfaces
{
    internal interface IPickupInterface
    {
        Task PickUpService(PickupDTO user);
    }
}
