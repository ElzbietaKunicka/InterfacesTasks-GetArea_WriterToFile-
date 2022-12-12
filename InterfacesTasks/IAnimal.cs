using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    //Sukurkite interface’ą IAnimal, jis turės metodus visus
    //būdingus visiems gyvūnams, pvz Eat().
    public interface IAnimal
    {
        string Name { get; set; }

        

        void Eat();
    }
}
