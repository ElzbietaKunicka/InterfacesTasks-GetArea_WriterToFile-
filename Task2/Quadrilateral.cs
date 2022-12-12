using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Quadrilateral : IPolygon
    {
        public double Side { get; set; }
      

        public Quadrilateral(double side)
        {
            Side = side;
        }

        public double GetAArea()
        {
            var area = Side * Side; 
            return area;
        }
    }
}
