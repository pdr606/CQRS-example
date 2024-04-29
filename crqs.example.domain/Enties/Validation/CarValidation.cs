using crqs.example.domain.Enties.CarContext;
using crqs.example.domain.Enties.Notifications;
using crqs.example.domain.Enties.Validation.Interface;

namespace crqs.example.domain.Enties.Validation
{
    public class CarValidation : IValidation
    {
        private readonly CarEntity _car;
        public CarValidation(CarEntity car)
        {
            this._car = car;
        }

        public CarValidation MinNameLength()
        {
            if (_car.Name.Length < 2)
                _car.PullNotification(
                        Notification.Create("Name", "O nome deve conter no mínimo 2 caracteres"));

            return
                this;
        }

        public CarValidation MinPriceValue()
        {
            if (_car.Info.Price < 0)
                _car.PullNotification(
                    Notification.Create("Price", "O valor do carror deve ser maior que 0"));

            return this;
        }

        public bool IsValid()
        {
            return 
                _car.Notifications.Count == 0;
        }
    }
}
