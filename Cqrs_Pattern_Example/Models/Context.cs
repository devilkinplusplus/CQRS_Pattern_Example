using Microsoft.EntityFrameworkCore;

namespace Cqrs_Pattern_Example.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MemoryDb");
        }

        public DbSet<Person> People { get; set; }
    }
}
