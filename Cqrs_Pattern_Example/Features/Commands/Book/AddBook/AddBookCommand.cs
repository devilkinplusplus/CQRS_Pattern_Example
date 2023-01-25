using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Book.AddBook
{
    public class AddBookCommand : IRequest
    {
        public Models.Book Book { get; set; }
    }
}
