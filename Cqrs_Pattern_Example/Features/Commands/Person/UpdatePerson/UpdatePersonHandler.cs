using Cqrs_Pattern_Example.Interfaces;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Person.UpdatePerson
{
    public class UpdatePersonHandler : IRequestHandler<UpdatePersonCommand, Models.Person>
    {
        private readonly IPersonService _personService;

        public UpdatePersonHandler(IPersonService personService) => _personService = personService;

        public async Task<Models.Person> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            _personService.UpdatePerson(request.Person);
            return request.Person;
        }
    }
}
