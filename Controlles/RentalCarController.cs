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
        private readonly ILogger _logger;
        public RentalCarController(RentSevice rentSevice, ILogger logger)
        {
            _rentSevice = rentSevice;
            _logger = logger;
        }

        [HttpPost("{Localidad}")]
        [Route("GetByLocation")]
         public async Task<IEnumerable<string>> GetByLocation([FromBody]RentDTO location)
        {
            _logger.LogInformation("Consultando todos los Vehiculos");

             //await _rentSevice.GetLocationCar(location);

            return new string[] {"value1","value2"};
        }
        [HttpPost]
        //public IEnumerable<List<ResponseDto>> PickUpService(PickupResquestDTO pickupResquestDTO)
        //{
        //    return null;
        //}
        //[HttpPut]
        //public IEnumerable<List<ResponseDto>> EditService(string UserID)
        //{
        //    return null;
        //}
        [HttpPost]
        public IEnumerable<List<ResponseDto>> DeliverService(string UserID)
        {

            //RETORNAR LOCALIDAD DE RETORNO
            return null;
        }
    }
}
