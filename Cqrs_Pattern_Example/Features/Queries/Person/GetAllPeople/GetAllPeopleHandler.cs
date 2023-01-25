using Cqrs_Pattern_Example.Interfaces;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Person.GetAllPeople
{
    public class GetAllPeopleHandler : IRequestHandler<GetAllPeopleQuery, List<Models.Person>>
    {
        private readonly IPersonService _personService;

        public GetAllPeopleHandler(IPersonService personService) => _personService = personService;

        public Task<List<Models.Person>> Handle(GetAllPeopleQuery request, CancellationToken cancellationToken)
        {
            return _personService.GetPeople();
        }
    }
}
