using Web.Api.Domain.Entities;
using Web.Api.Domain.Interfaces;

namespace Web.Api.Domain.Services
{
    public class RentSevice : IRentInterface
    {
        public RentSevice() { }
        public List<RentDTO> GetLocationCar(string Localidad)
        {
            List<RentDTO>  ss = new List<RentDTO>();
            return ss;
        }
    }
}