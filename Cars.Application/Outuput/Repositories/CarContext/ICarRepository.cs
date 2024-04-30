using Cars.Application.Outuput.Requests.CarRequests;
using crqs.example.domain.Enties.CarContext;

namespace Cars.Application.Outuput.Repositories.CarContext
{
    public interface ICarRepository
    {
        void InsertCar(CarEntity car);
        Task<CarRequest> GetCarByName(string name);
    }
}
