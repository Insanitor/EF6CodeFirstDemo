using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("SchoolDBConnectionString")
        {
            Database.SetInitializer<AnimalContext>(new DropCreateDatabaseIfModelChanges<AnimalContext>());
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
