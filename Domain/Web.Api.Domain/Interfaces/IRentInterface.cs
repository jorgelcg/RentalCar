using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Interfaces
{
    public interface IRentInterface
    {
        Task<Vehicle> GetLocationCar(string Localidad);
    }
}
