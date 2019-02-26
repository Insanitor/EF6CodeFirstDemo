using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF6CodeFirstDemo.Models.School;
using EF6CodeFirstDemo.Models.Inheritance;
using static System.Console;

namespace EF6CodeFirstDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var ctx = new AnimalContext())
            {
                var dog = new Dog() { Name = "Fido" };
                var Kitty = new Kitty() { Name = "Figaro Jr." };

                ctx.Animals.Add(dog);
                ctx.Animals.Add(Kitty);
                ctx.SaveChanges();
                Console.WriteLine(WriteRw("Message Here!"));
            }
        }

        void Write(string writeStuff)
        {
            Console.WriteLine(writeStuff);
        }

        static string WriteRw(string writeStuff)
        {
            return writeStuff;
        }
    }
}
