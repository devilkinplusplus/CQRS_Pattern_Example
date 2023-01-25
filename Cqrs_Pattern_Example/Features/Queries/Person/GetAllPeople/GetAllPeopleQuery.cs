using Cqrs_Pattern_Example.Models;
using MediatR;

namespace Cqrs_Pattern_Example.Features.Queries.Person.GetAllPeople
{
    public class GetAllPeopleQuery:IRequest<List<Models.Person>>
    {
    }
}
