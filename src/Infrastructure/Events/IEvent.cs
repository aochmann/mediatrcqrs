using System;
using MediatR;

namespace CQRS_WithMediatr.Infrastructure.Events
{
    public interface IEvent : INotification
    {
        Guid Id { get; }
    }
}