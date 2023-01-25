using Cqrs_Pattern_Example.Interfaces;
using MediatR;
using Microsoft.AspNetCore.DataProtection;

namespace Cqrs_Pattern_Example.Features.Commands.Person.DeletePerson
{
    public class DeletePersonHandler : IRequestHandler<DeletePersonCommand, Unit>
    {
        private readonly IPersonService _personService;

        public DeletePersonHandler(IPersonService personService) => _personService = personService;

        public async Task<Unit> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            _personService.DeletePerson(request.Id);
            return Unit.Value;
        }
    }
}
