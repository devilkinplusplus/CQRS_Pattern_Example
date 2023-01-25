using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Person.UpdatePerson
{
    public class UpdatePersonCommand:IRequest<Models.Person>
    {
        public Models.Person Person { get; set; }
    }
}
