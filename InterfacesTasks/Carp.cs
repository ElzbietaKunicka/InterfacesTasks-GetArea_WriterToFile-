using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    //Sukurkite klasę Carp, kuri paveldės tiek iš IAnimal, tiek iš IFish.
    public class Carp : IAnimal, IFish
    {
        public string Name { get; set; }

        public Carp(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Carp eating");
        }

        public void Swim()
        {
            Console.WriteLine("Carp swimming");
        }
    }
}
