using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Circle : Object2D
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius < 0) throw new Exception("Cannot create object with negative dimensions");
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Circle (r = {0})", Radius);
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}