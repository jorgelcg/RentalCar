using Microsoft.AspNetCore.Mvc;
using Web.Api.Domain.Services;
using Web.Api.Infrastructure.Models;

namespace RentalCar.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalCarController : ControllerBase
    {
        private readonly RentSevice _Service;

        public RentalCarController(RentSevice rentSevice) => _Service = rentSevice;

        [HttpGet]
        [Route("GetByLocation")]
        public async Task<IActionResult> GetByLocation(string Localidad)
        {
            var vehivle = await _Service.GetLocationCar(Localidad);
            if (vehivle is null)
            {
                return NotFound();
            }
            return Ok(vehivle);
        }

        [HttpPut]
        [Route("PickUpService")]
        public async Task<Vehicle> PickUp(int IdVehicle, int cantidadays, string IdUser)
        {
           var _ = await _Service.PickUpService(IdVehicle,cantidadays,IdUser);

            return _;
        }
        [HttpDelete]
        [Route("DeliverService")]
        public async Task<IActionResult> DeliverService(int IdVehicle, DateTime Fechadeentrega )
        {
            var _ = await _Service.DeliverService(IdVehicle);

            return Ok("Entrega ajendada el:  " + Fechadeentrega + " en la localidad de:  " + _.Location);
        } 
        }
}
