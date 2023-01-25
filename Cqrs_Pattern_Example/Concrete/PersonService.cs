using Cqrs_Pattern_Example.Interfaces;
using Cqrs_Pattern_Example.Models;
using Microsoft.EntityFrameworkCore;

namespace Cqrs_Pattern_Example.Concrete
{
    public class PersonService : IPersonService
    {
        public async Task AddPerson(Person person)
        {
            using var context = new Context();
            context.People.Add(person);
            await context.SaveChangesAsync();
        }

        public async Task DeletePerson(int id)
        {
            using var context = new Context();
            var data = await context.People.FindAsync(id);
            context.People.Remove(data);
            await context.SaveChangesAsync();
        }

        public async Task<Person> Get(int id)
        {
            using var context = new Context();
            return await context.People.FindAsync(id);
        }

        public async Task<List<Person>> GetPeople()
        {
            using var context = new Context();
            return await context.People.ToListAsync();
        }

        public async Task UpdatePerson(Person person)
        {
            using var context = new Context();
            context.People.Update(person);
            await context.SaveChangesAsync();
        }
    }
}
