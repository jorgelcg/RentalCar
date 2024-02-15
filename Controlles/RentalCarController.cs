using Microsoft.AspNetCore.Mvc;

namespace RentalCar.Controlles
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalCarController : ControllerBase
    {
        public RentalCarController()
        { 
        }
        [HttpGet]
        public IActionResult GetAllCars()
        {

            return Ok();
        }
    }
}
