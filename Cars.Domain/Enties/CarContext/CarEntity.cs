using crqs.example.domain.Enties.Validation;
using crqs.example.domain.Enties.Validation.Interface;
using crqs.example.domain.Enties.ValueObjects;

namespace crqs.example.domain.Enties.CarContext
{
    public class CarEntity : BaseEntity, IValidation
    {
        private CarEntity(string name, Stats stats)
        {
            this.Name = name;
            this.Info = stats;
        }

        protected CarEntity() { }

        public string Name { get; private set; } 
        public Stats Info { get; private set; }

        public static CarEntity Create(string name, Stats stats)
        {
            return
                new CarEntity(name, stats);
        }

        public override bool IsValid()
        {
            return 
                new CarValidation(this)
                        .MinNameLength()
                        .MinPriceValue()
                        .IsValid();
        }
    }
}
