using System.Threading.Tasks;
using MediatR;

namespace CQRS_WithMediatr.Infrastructure.CQRS.Commands
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand>
        where TCommand: ICommand
    {
        
    }
}