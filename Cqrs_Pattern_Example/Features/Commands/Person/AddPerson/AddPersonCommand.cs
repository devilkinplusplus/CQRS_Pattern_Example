using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Person.AddPerson
{
    public class AddPersonCommand : IRequest
    {
        public Models.Person Person { get; set; }
    }
}
