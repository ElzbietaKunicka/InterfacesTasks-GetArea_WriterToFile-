using System.ComponentModel.DataAnnotations;

namespace Task2
{
    internal class Program
    {
        //Sukurkite interface’ą IPolygon su metodu double GetArea()\

        //Sukurkite klases Triangle, Quadrilateral, Pentagod, Hexagon ir paveldėkite IPolygon interface’ą.​

        // Implementuokite skaičiavimus.
        //Pabandykite implementuoti IComparable<> interfeisą pagal gautą figūros plotą.
        static void Main(string[] args)
        {
            var triangle = new Triangle(2, 3);
            var result = triangle.GetAArea();
            Console.WriteLine($"triangle area is: {result}");

            var quadrilaterial = new Quadrilateral(7);
            var resultQuadri = quadrilaterial.GetAArea();
            Console.WriteLine($"quadrilaterial area is: {resultQuadri}");

            var pentagon = new Pentagod(5, 3);
            var resultPentagon = pentagon.GetAArea();
            Console.WriteLine($"pentagon area is: {resultPentagon}");
            
            var hexagon = new Hexagon(5);
            var resultHexagon = hexagon.GetAArea();
            Console.WriteLine($"hexagon area is: {resultHexagon}");

            var figureList = new List<IPolygon>
            {
                new Triangle(8, 3),
                new Triangle(2, 3),
                new Quadrilateral(7),
                new Pentagod(5, 3),
                new Hexagon(5),
            };

            var areaComparer = new AreComparer();
            figureList.Sort(areaComparer);
            Console.ReadLine();
            

        }
    }
}