using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle : IPolygon
    {
       public double TriangleBase { get; set; } 
       public double Height { get; set; }

    public Triangle(double triangleBase, double height)
        {
            TriangleBase = triangleBase;
            Height = height;
        }

        public double GetAArea()
        {

            double area = (TriangleBase * Height) / 2;
            return area;
        }
    }
}
