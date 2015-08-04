using System.Data.Entity;

namespace Del2.Models
{
    public class PersonsContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}