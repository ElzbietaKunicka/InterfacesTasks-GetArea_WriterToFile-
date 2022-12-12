using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTasks
{
    public class AnimalComparer : IComparer<IAnimal>
    {
        public int Compare(IAnimal? x, IAnimal? y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
