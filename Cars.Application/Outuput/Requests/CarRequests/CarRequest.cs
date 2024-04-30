using Cars.Application.Outuput.DTO;
using Cars.Application.Outuput.Requests.Interfaces;
using cqrs.example.application.Outuput.Results;

namespace Cars.Application.Outuput.Requests.CarRequests
{
    public class CarRequest : IRequestBase
    {
        public Result Result { get; set; }
        public CarDTO Car { get; set; }
    }
}
