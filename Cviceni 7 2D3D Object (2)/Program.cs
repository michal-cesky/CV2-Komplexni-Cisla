using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers =
            {
                1, 3, 5, 7, 9
            };

            string[] strings =
            {
                "text", "text1", "testingtext", "blabla", "aaaaaaaaaaaaaa"
            };

            Circle[] circles = { new Circle(3),
                                 new Circle(2),
                                 new Circle(7) };

            Rectangle[] rectangles = { new Rectangle(3, 5),
                                       new Rectangle(2, 2),
                                       new Rectangle(4, 3) };

            Ellipse[] ellipses = { new Ellipse(2, 3),
                                   new Ellipse(4, 4),
                                   new Ellipse(2, 5) };

            Triangle[] triangles = { new Triangle(3, 4, 5),
                                     new Triangle(4, 6, 7),
                                     new Triangle(2, 5, 6) };

            Square[] squares = { new Square(2),
                                 new Square(4),
                                 new Square(3) };

            Object2D[] objects = { new Circle(3),
                                   new Triangle(2, 4, 5),
                                   new Square(4) };

            Console.WriteLine("Largest int: " + Extremes.Largest(integers));
            Console.WriteLine("Smallest int: " + Extremes.Smallest(integers) + "\n");

            Console.WriteLine("Largest string: " + Extremes.Largest(strings));
            Console.WriteLine("Smallest string: " + Extremes.Smallest(strings) + "\n");

            Console.WriteLine("Largest circle: " + Extremes.Largest(circles));
            Console.WriteLine("Smallest circle: " + Extremes.Smallest(circles) + "\n");

            Console.WriteLine("Largest rectangle: " + Extremes.Largest(rectangles));
            Console.WriteLine("Smallest rectangle: " + Extremes.Smallest(rectangles) + "\n");

            Console.WriteLine("Largest ellipse: " + Extremes.Largest(ellipses));
            Console.WriteLine("Smallest ellipse: " + Extremes.Smallest(ellipses) + "\n");

            Console.WriteLine("Largest triangle: " + Extremes.Largest(triangles));
            Console.WriteLine("Smallest triangle: " + Extremes.Smallest(triangles) + "\n");

            Console.WriteLine("Largest square: " + Extremes.Largest(squares));
            Console.WriteLine("Smallest square: " + Extremes.Smallest(squares) + "\n");

            Console.WriteLine("Largest object: " + Extremes.Largest(objects));
            Console.WriteLine("Smallest object: " + Extremes.Smallest(objects) + "\n");

            IEnumerable<int> intArray = integers.Where(integer => (integer >= 4) && (integer <= 8));
            Console.WriteLine("Filtered integers:");
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
