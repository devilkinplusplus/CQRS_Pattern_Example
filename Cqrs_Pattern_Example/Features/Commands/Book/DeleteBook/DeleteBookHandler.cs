using Cqrs_Pattern_Example.Models;
using MediatR;
using System.Data;

namespace Cqrs_Pattern_Example.Features.Commands.Book.DeleteBook
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookCommand, Models.Book>
    {
        private readonly DataStore _dataStore;

        public DeleteBookHandler(DataStore dataStore) => _dataStore = dataStore;

        public Task<Models.Book> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var data = _dataStore.DeleteAsync(request.Id);
            return data;
        }
    }
}
