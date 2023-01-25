using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Book.GetBooks
{
    public class GetBooksHandler : IRequestHandler<GetBooksQuery, IEnumerable<Models.Book>>
    {
        private readonly DataStore _dataStore;

        public GetBooksHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Models.Book>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetBooksAsync();
        }
    }
}
