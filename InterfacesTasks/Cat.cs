using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    public class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Cat eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Cats are mammals.");
        }
    }
}
