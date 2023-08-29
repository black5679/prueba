using Microsoft.AspNetCore.Mvc;
using MediatR;
using LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.Get;
using LibeyTechnicalTest.Backend.Application.Queries.LibeyUser.GetByDocumentNumber;
using LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Insert;
using LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Update;
using LibeyTechnicalTest.Backend.Application.Commands.LibeyUser.Delete;

namespace LibeyTechnicalTest.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibeyUserController : ControllerBase
    {
        private readonly IMediator mediator;
        public LibeyUserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await mediator.Send(new GetLibeyUserQuery());
            return Ok(response);
        }
        [HttpGet("{DocumentNumber}")]
        public async Task<IActionResult> Get([FromRoute] GetByDocumentNumberLibeyUserQuery query)
        {
            var response = await mediator.Send(query);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] InsertLibeyUserCommand command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpPatch("{documentNumber}")]
        public async Task<IActionResult> Update([FromRoute] string documentNumber, [FromBody] UpdateLibeyUserCommand command)
        {
            command.DocumentNumber = documentNumber;
            var response = await mediator.Send(command);
            return Ok(response);
        }
        [HttpDelete("{DocumentNumber}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteLibeyUserCommand command)
        {
            var response = await mediator.Send(command);
            return Ok(response);
        }
    }
}
