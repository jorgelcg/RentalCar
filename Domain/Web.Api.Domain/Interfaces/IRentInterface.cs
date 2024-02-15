using Web.Api.Infrastructure.Models;

namespace Web.Api.Domain.Interfaces
{
    public interface IRentInterface
    {
        Task<IEnumerable<Vehicle>> GetLocationCar(string Localidad);
    }
}
