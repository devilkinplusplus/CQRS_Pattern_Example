using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Person.GetById
{
    public class GetByIdQuery:IRequest<Models.Person>
    {
        public int Id { get; set; }
    }
}
