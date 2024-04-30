using Cars.Application.Outuput.Repositories.CarContext;
using cqrs.example.application.Input.Commands.CarContext;
using cqrs.example.application.Input.Handlers.Interfaces;
using cqrs.example.application.Outuput.Results;
using cqrs.example.application.Outuput.Results.Interfaces;
using crqs.example.domain.Enties.CarContext;
using crqs.example.domain.Enties.Notifications;

namespace cqrs.example.application.Input.Handlers.CarContext
{
    public class InsertCarHandler : IHandlerBase<InsertCarCommand>
    {
        private readonly ICarRepository _carRepository;

        public InsertCarHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IResultBase Handle(InsertCarCommand command)
        {
            var car = CarEntity.Create(command.Name, command.Info);

            if (car.IsValid())
            {
                try
                {
                    _carRepository.InsertCar(car);

                    return
                        Result.Create(200, $"Carro criado com sucesso", true);
                }
                catch (Exception ex)
                {
                    return
                        Result.Create(500, $"Falha interna do servidor, detalhes: {ex.Message}", false);
                }
            }

            return 
                Result.Create(400, $"Falha ao inserir o carro na base de dados, verifique os campos e tente novamente.", false)
                      .SetNotifications(car.Notifications as List<Notification>);
        }
    }
}
