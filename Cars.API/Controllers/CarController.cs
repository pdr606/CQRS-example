using Cars.Application.Outuput.DTO;
using Cars.Application.Outuput.Repositories.CarContext;
using Cars.Application.Outuput.Requests.CarRequests;
using cqrs.example.application.Input.Commands.CarContext;
using cqrs.example.application.Input.Handlers.CarContext;
using cqrs.example.application.Outuput.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace cqrs_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost("/PostCar")]
        public Result PostCar([FromServices] InsertCarHandler handler, [FromBody] InsertCarCommand command)
        {
            return (Result)handler.Handle(command);
        }

        [AllowAnonymous]
        [HttpGet("/{name}")]
        public async Task<CarRequest> FindCarByName([FromServices] ICarRepository carRepository, [FromRoute] string name)
        {
            return
                await carRepository.GetCarByName(name);
        }
    }
}
