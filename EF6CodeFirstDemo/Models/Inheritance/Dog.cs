using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    [Table("Dogs")]
    public class Dog : Animal
    {
        private int cuteness;

        public Dog()
        {
        }

        public Dog(string name) : base(name)
        {
        }

        public int Cuteness
        {
            get { return cuteness; }
            set { cuteness = value; }
        }

    }
}
