using cqrs.example.application.Input.Commands.Interfaces;
using crqs.example.domain.Enties.ValueObjects;

namespace cqrs.example.application.Input.Commands.CarContext
{
    public class InsertCarCommand : ICommandBase
    {
        public string Name { get; set; }
        public Stats Info { get; set; }
    }
}
