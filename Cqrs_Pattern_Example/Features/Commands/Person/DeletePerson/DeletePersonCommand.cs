using MediatR;

namespace Cqrs_Pattern_Example.Features.Commands.Person.DeletePerson
{
    public class DeletePersonCommand:IRequest
    {
        public int Id { get; set; }
    }
}
