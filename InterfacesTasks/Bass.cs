using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    //Sukurkite klasę Bass, kuri paveldės tiek iš IAnimal, tiek iš IFish.
    public class Bass : IAnimal, IFish
    {
        public string Name { get; set; }

        public Bass(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Bass eating");
        }

        public void Swim()
        {
            Console.WriteLine("Bass swimming");
        }
    }
}
