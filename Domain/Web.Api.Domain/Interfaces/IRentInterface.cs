using Web.Api.Domain.Entities;

namespace Web.Api.Domain.Interfaces
{
    public interface IRentInterface
    {
        List<RentDTO> GetLocationCar(string Localidad);
    }
}
