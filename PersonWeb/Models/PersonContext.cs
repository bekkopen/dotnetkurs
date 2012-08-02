using System.Data.Entity;

namespace PersonWeb.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        static PersonContext()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<PersonContext>());
        }
    }
}