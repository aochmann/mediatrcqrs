using MediatR;

namespace CQRS_WithMediatr.Infrastructure.CQRS.Queries
{
    public interface IQueryHandler<in TQuery, TQueryResult> : IRequestHandler<TQuery, TQueryResult>
        where TQuery: IQuery, IRequest<TQueryResult>
        where TQueryResult: IQueryResult
    {
         
    }
}