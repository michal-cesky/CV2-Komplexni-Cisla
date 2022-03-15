using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Piramid : Object3D
    {
        public double a { get; private set; }
        public double v { get; private set; }

        public Piramid(double width, double height)
        {
            if (width < 0 || height < 0) throw new Exception("you cant use negative numbers");
            this.a = width;
            this.v = height;

        }
        public override void Draw()
        {
            Console.WriteLine("\nSphere  a={0} v={1} ", a, v);
        }
        public override double CalculateSurfaceArea()
        {
            return (4 * (a * v)/2) + (a * a);
        }

        public override double CalculateVolume()
        {
            return (a * a * v) / 3;

        }
    }
}

