using Microsoft.AspNetCore.Mvc;
using RentalCar.DTOs;
using Web.Api.Domain.Entities;
using Web.Api.Domain.Services;

namespace RentalCar.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalCarController : ControllerBase
    {
        private readonly RentSevice _rentSevice;
        
        public RentalCarController(RentSevice rentSevice)
        {
            _rentSevice = rentSevice;
        }

        [HttpGet]
        [Route("GetByLocation")]
        public IActionResult GetByLocation(string Localidad)
        {
            List<RentDTO> _ = _rentSevice.GetLocationCar(Localidad);

            return Ok(_);
        }
        [HttpPut]
        [Route("PickUpService")]
        public IEnumerable<List<ResponseDto>> PickUpService([FromBody] PickupResquestDTO pickupResquestDTO)
        {
            return null;
        }
        [HttpPost]
        [Route("DeliverService")]
        public IEnumerable<List<ResponseDto>> DeliverService([FromBody] DeliverRequestDTO deliverRequestDTO)
        {

            //RETORNAR LOCALIDAD DE RETORNO
            return null;
        }
    }
}
