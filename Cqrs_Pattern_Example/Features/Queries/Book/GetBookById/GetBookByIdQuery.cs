using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Book.GetBookById
{
    public class GetBookByIdQuery : IRequest<Models.Book>
    {
        public int Id { get; set; }
    }
}
