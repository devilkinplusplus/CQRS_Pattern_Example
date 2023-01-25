using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Book.AddBook
{
    public class AddBookHandler : IRequestHandler<AddBookCommand, Unit>
    {
        private readonly DataStore _dataStore;
        public AddBookHandler(DataStore dataStore) => _dataStore = dataStore;

        public async Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.AddAsync(request.Book);
            return Unit.Value;
        }
    }
}
