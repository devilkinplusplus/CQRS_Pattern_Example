using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Book.DeleteBook
{
    public class DeleteBookCommand : IRequest<Models.Book>
    {
        public int Id { get; set; }
    }
}
