using System;
using System.Threading.Tasks;
using CQRS_WithMediatr.Infrastructure.CQRS.Commands;
using CQRS_WithMediatr.Infrastructure.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_WithMediatr.Infrastructure.CQRS.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
            => _mediator = mediator;

        public async Task<IActionResult> TryDispatch<TCommand>(TCommand command) where TCommand : ICommand
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                await _mediator.Send(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<TQueryResult> TryGet<TQuery, TQueryResult>(TQuery query)
            where TQuery : IQuery, IRequest<TQueryResult>
            where TQueryResult: class, IQueryResult
        {
            return await _mediator.Send<TQueryResult>(query);
        }
    }
}