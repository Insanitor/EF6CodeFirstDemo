using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    public abstract class Animal
    {
        private string name;

        public Animal()
        {
        }

        public Animal(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int ownerId;
        [Key]
        public int OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }


    }
}
