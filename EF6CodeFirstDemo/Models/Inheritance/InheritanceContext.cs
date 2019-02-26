using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    class InheritanceContext : DbContext
    {
        public InheritanceContext() : base("SchoolDBConnectionString")
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
