using Cqrs_Pattern_Example.Interfaces;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Person.GetById
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Models.Person>
    {
        private readonly IPersonService _personService;

        public GetByIdHandler(IPersonService personService) => _personService = personService;

        public Task<Models.Person> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            return _personService.Get(request.Id);
        }
    }
}
