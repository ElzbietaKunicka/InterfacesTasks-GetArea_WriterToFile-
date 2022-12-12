using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    //Sukurkite klasę Dog, kuri paveldės tiek iš IAnimal, tiek iš IMammal.
    public class Dog : IAnimal, IMammal
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Dog eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Dogs are mammals.");
        }
    }
}
