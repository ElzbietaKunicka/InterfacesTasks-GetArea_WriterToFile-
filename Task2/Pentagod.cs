using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Pentagod : IPolygon
    {
        double Perimeter { get; set; }
        double Apothem { get; set; }

        public Pentagod(double perimeter, double apothem)
        {
            Perimeter = perimeter;
            Apothem = apothem;
        }
        public double GetAArea()
        {
            var result = 0.5 * Perimeter * Apothem;
            return result;
        }
    }
}
