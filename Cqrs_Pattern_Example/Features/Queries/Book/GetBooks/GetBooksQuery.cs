using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Book.GetBooks
{
    public class GetBooksQuery : IRequest<IEnumerable<Models.Book>>
    {
    }
}
