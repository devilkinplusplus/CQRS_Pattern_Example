using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Book.UpdateBook
{
    public class UpdateBookCommand : IRequest
    {
        public Models.Book Book { get; set; }
    }
}
