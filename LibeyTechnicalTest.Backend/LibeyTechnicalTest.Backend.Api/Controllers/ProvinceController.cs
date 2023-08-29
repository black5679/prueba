using LibeyTechnicalTest.Backend.Application.Queries.Province.GetByRegionCode;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibeyTechnicalTest.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProvinceController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("GetByRegionCode/{RegionCode}")]
        public async Task<IActionResult> GetByRegionCode([FromRoute] GetByRegionCodeProvinceQuery query)
        {
            var response = await mediator.Send(query);
            return Ok(response);
        }
    }
}
