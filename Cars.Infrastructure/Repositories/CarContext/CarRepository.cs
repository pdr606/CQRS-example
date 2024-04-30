using Cars.Application.Outuput.Repositories.CarContext;
using Cars.Application.Outuput.Requests.CarRequests;
using Cars.Infrastructure.Data;
using cqrs.example.application.Outuput.Results;
using crqs.example.domain.Enties.CarContext;
using Microsoft.EntityFrameworkCore;

namespace Cars.Infrastructure.Repositories.CarContext
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<CarEntity> _db;

        public CarRepository(DataContext context)
        {
            _context = context;
            _db = _context.Set<CarEntity>();
        }

        public void InsertCar(CarEntity car)
        {
            _db.Add(car);
            _context.SaveChanges();
        }

        public async Task<CarRequest> GetCarByName(string name)
        {
            var carRequest = new CarRequest();

            try
            {
                var car = await _db.FirstOrDefaultAsync(x => x.Name == name);

                if (car == null)
                {
                    carRequest.Result = Result.Create(404, $"Não foi encontrando um carro com o nome: {name}", false);
                    return 
                        carRequest;
                }

                carRequest.Result = Result.Create(200, "Requisição realizada com succeso", true);

                carRequest.Car = new Application.Outuput.DTO.CarDTO()
                {
                    Id = car.Id,
                    Name = car.Name,
                    Info = car.Info,
                };

                return carRequest;

            } catch (Exception ex)
            {
                carRequest.Result = Result.Create(500, $"Error interno do servidor, detalhes: {ex.Message}", false);
                return 
                    carRequest;
            }
        }
    }
}
