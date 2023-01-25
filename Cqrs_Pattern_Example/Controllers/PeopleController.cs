using Cqrs_Pattern_Example.Features.Commands.Person.AddPerson;
using Cqrs_Pattern_Example.Features.Commands.Person.DeletePerson;
using Cqrs_Pattern_Example.Features.Commands.Person.UpdatePerson;
using Cqrs_Pattern_Example.Features.Queries.Book.GetBookById;
using Cqrs_Pattern_Example.Features.Queries.Person.GetAllPeople;
using Cqrs_Pattern_Example.Features.Queries.Person.GetById;
using Cqrs_Pattern_Example.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs_Pattern_Example.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PeopleController(IMediator mediator) => _mediator = mediator;

        [HttpGet("getpeople")]
        public async Task<IActionResult> GetAll()
        {
            var query = await _mediator.Send(new GetAllPeopleQuery());
            return Ok(query);
        }

        [HttpGet("getperson")]
        public async Task<IActionResult> Get(int id)
        {
            var query = await _mediator.Send(new GetByIdQuery() { Id = id });
            return Ok(query);
        }

        [HttpPost("addperson")]
        public async Task<IActionResult> Post([FromBody] Person person)
        {
            var command = await _mediator.Send(new AddPersonCommand() { Person = person });
            return Created("Created Succesfully", person);
        }

        [HttpPut("editperson")]
        public async Task<IActionResult> Put([FromBody] Person person)
        {
            var command = await _mediator.Send(new UpdatePersonCommand() { Person = person });
            return NoContent();
        }

        [HttpDelete("deleteperson")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = await _mediator.Send(new DeletePersonCommand() { Id = id });
            return NoContent();
        }
    }
}
