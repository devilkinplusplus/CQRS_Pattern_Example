using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Book.GetBookById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdQuery, Models.Book>
    {
        private readonly DataStore _dataStore;

        public GetBookByIdHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Models.Book> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetBookById(request.Id);
        }
    }
}
