using LibeyTechnicalTest.Backend.Application.Queries.Ubigeo.GetByProvinceCode;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTest.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UbigeoController : ControllerBase
    {
        private readonly IMediator mediator;
        public UbigeoController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("GetByProvinceCode/{ProvinceCode}")]
        public async Task<IActionResult> GetByProvinceCode([FromRoute] GetByProvinceCodeUbigeoQuery query)
        {
            var response = await mediator.Send(query);
            return Ok(response);
        }
    }
}
