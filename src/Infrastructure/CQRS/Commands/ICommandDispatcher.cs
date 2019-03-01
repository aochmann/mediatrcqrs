using System.Threading.Tasks;

namespace CQRS_WithMediatr.Infrastructure.CQRS.Commands
{
    public interface ICommandDispatcher
    {
         Task Dispatch<TCommand>(TCommand command) where TCommand : ICommand;
    }
}