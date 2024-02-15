using Microsoft.AspNetCore.Mvc;
using RentalCar.DTOs;
using System.Collections;

using Web.Api.Domain.Services;
using Web.Api.Infrastructure.Models;

namespace RentalCar.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalCarController : ControllerBase
    {
        private readonly RentSevice _rentSevice;
        private readonly PickupService _pickupService;
        private readonly DeliverServicecs _deliverServicecs;

        public RentalCarController(RentSevice rentSevice,
            PickupService pickupService, DeliverServicecs deliverServicecs)
        {
            _rentSevice = rentSevice;
            _pickupService = pickupService;
            _deliverServicecs = deliverServicecs;
        }

        [HttpGet]
        [Route("GetByLocation")]
        public IEnumerable GetByLocation(string Localidad)
        {
          var _ = _rentSevice.GetLocationCar(Localidad);

            return (IEnumerable)_;
        }
        //Service does not work....
        [HttpPost]
        [Route("PickUpService")]
        public  IEnumerable PickUp(Vehicle pickup)
        {
            //var pickups = _pickupService.PickUpService(pickup);

            //return (IEnumerable)pickups;

            return (IEnumerable)NoContent();
        }
        [HttpDelete]
        [Route("DeliverService")]
        public IEnumerable<List<ResponseDto>> DeliverService(string deliverDTO)
        {
         var d =  _deliverServicecs.DeliverService(deliverDTO);

            return (IEnumerable<List<ResponseDto>>)d;
        }
    }
}
