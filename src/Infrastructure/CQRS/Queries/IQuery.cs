using MediatR;

namespace CQRS_WithMediatr.Infrastructure.CQRS.Queries
{
    public interface IQuery<TQuery, TQueryResult> : IQuery, IRequest<TQueryResult>
    where TQueryResult : IQueryResult
    where TQuery : class,  IQuery, new ()
    {

    }

    public interface IQuery
    {
        
    }
}