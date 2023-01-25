using Cqrs_Pattern_Example.Models;

namespace Cqrs_Pattern_Example.Interfaces
{
    public interface IPersonService
    {
        Task<List<Person>> GetPeople();
        Task<Person> Get(int id);
        Task AddPerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(int id);
    }
}
