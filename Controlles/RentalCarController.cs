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

        //get data by location to collection vehicle
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
        //update date to collection vehicle
        [HttpPut]
        [Route("PickUpService")]
        public async Task<Vehicle> PickUp(int IdVehicle, int cantidadays, string IdUser)
        {
           var _ = await _Service.PickUpService(IdVehicle,cantidadays,IdUser);

            return _;
        }
        //update date to collection vehicle, an returning datetame an location to return it.
        [HttpDelete]
        [Route("DeliverService")]
        public async Task<IActionResult> DeliverService(int IdVehicle, DateTime Fechadeentrega )
        {
            var _ = await _Service.DeliverService(IdVehicle);

            return Ok("Entrega ajendada el:  " + Fechadeentrega + " en la localidad de:  " + _.Location);
        } 
        }
}
