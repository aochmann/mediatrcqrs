using CQRS_WithMediatr.Infrastructure.CQRS.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_WithMediatr.Controllers
{
    [Route("api/[controller]")]
    public class PingController : BaseController
    {
        public PingController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public IActionResult Get()
            => Ok("pong");
    }
}