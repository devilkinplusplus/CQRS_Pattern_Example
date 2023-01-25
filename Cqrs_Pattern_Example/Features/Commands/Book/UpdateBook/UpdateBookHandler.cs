using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Book.UpdateBook
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookCommand, Unit>
    {
        private readonly DataStore _dataStore;

        public UpdateBookHandler(DataStore dataStore) => _dataStore = dataStore;

        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.UpdateAsync(request.Book);
            return Unit.Value;
        }
    }
}
