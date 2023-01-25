using Cqrs_Pattern_Example.Interfaces;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Person.AddPerson
{
    public class AddPersonHandler : IRequestHandler<AddPersonCommand, Unit>
    {
        private readonly IPersonService _personService;

        public AddPersonHandler(IPersonService personService) => _personService = personService;

        public async Task<Unit> Handle(AddPersonCommand request, CancellationToken cancellationToken)
        {
            _personService.AddPerson(request.Person);
            return Unit.Value;
        }
    }
}
