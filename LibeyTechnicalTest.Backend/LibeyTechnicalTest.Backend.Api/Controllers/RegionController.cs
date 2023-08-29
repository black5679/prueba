using LibeyTechnicalTest.Backend.Application.Queries.Region.Get;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTest.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IMediator mediator;
        public RegionController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await mediator.Send(new GetRegionQuery());
            return Ok(response);
        }
    }
}
