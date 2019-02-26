using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    [Table("Cats")]
    public abstract class Cat : Animal
    {
        private int independance;

        public Cat()
        {
        }

        public Cat(string name) : base(name)
        {

        }

        public int Independance
        {
            get { return independance; }
            set { independance = value; }
        }

    }
}
