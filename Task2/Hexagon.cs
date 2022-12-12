
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Hexagon : IPolygon
    {
        public double Length { get; set; }

        public Hexagon(double length)
        {
            Length = length;
        }

        public double GetAArea()
        {
            var area = (3 * Math.Sqrt(3) * (Length * Length) / 2);
            return area;
        }
    }
}

