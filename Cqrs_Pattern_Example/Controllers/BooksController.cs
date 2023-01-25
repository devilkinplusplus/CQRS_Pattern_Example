using Cqrs_Pattern_Example.Features.Commands.Book.AddBook;
using Cqrs_Pattern_Example.Features.Commands.Book.DeleteBook;
using Cqrs_Pattern_Example.Features.Commands.Book.UpdateBook;
using Cqrs_Pattern_Example.Features.Queries.Book.GetBookById;
using Cqrs_Pattern_Example.Features.Queries.Book.GetBooks;
using Cqrs_Pattern_Example.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs_Pattern_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var query = _mediator.Send(new GetBooksQuery());
            return Ok(query);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var query = _mediator.Send(new GetBookByIdQuery() { Id = id });
            return Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Book book)
        {
            await _mediator.Send(new AddBookCommand() { Book = book });
            return StatusCode(201);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Book book)
        {
            await _mediator.Send(new UpdateBookCommand() { Book = book });
            return StatusCode(204);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _mediator.Send(new DeleteBookCommand() { Id = id });
            return Ok(data);
        }
    } 
}
