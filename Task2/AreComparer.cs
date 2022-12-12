using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AreComparer : IComparer<IPolygon>
    {
        public int Compare(IPolygon? x, IPolygon? y)
        {
            var xArea = x.GetAArea();
            var yArea = y.GetAArea();

            if(xArea > yArea) 
            {
                return 1;
            }else if(xArea < yArea)
            {
                return -1;
            }else
            {
                return 0;
            }
        }
    }
}
