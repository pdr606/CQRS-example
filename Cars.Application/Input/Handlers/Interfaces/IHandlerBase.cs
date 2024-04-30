using cqrs.example.application.Input.Commands.Interfaces;
using cqrs.example.application.Outuput.Results.Interfaces;

namespace cqrs.example.application.Input.Handlers.Interfaces
{
    public interface IHandlerBase<in T> where T : ICommandBase
    {
        IResultBase Handle(T command);
    }
}
