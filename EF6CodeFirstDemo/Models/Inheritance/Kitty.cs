using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6CodeFirstDemo.Models.Inheritance
{
    [Table("Kittens")]
    public class Kitty : Cat
    {
        private int purrfectness;

        public int Purrfectness
        {
            get { return purrfectness; }
            set { purrfectness = value; }
        }

    }
}
