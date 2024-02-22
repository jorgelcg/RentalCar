using Microsoft.AspNetCore.Mvc;
using Web.Api.Domain.Services;

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
        
        /*[HttpPost]
        [Route("PickUpService")]
        public async Task<IActionResult> PickUp(PickupDTO pickup)
        {
            //var pickups = _pickupService.PickUpService(pickup);

            //return (IEnumerable)pickups;

            return (IEnumerable)NoContent();
        }*/

        /*[HttpPut]
        [Route("DeliverService")]
        public IEnumerable<List<ResponseDto>> DeliverService(string IdVehicle)
        {
         var d = _deliverInterface.DeliverService(IdVehicle);

            return (IEnumerable<List<ResponseDto>>)d;
        }*/
    }
}
