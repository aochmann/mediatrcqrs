using MediatR;

namespace CQRS_WithMediatr.Infrastructure.Events
{
    public interface IEventHandler<TEvent> : INotificationHandler<TEvent>
        where TEvent: IEvent, INotification
    {
         
    }
}