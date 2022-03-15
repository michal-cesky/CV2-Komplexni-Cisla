using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Cilinder : Object3D
    {
        public double r { get; private set; }
        public double v { get; private set; }

        public Cilinder(double radius, double height)
        {
            if (radius < 0 || height < 0 ) throw new Exception("you cant use negative numbers");
            this.r = radius;
            this.v = height;
        

        }
        public override void Draw()
        {
            Console.WriteLine("\nCilinder  r={0} x b={1} ", r, v);
        }
        public override double CalculateSurfaceArea()
        {
            return 2 * (Math.PI * r * r)+(2* Math.PI*r*v);
        }

        public override double CalculateVolume()
        {
            return Math.PI * r * r * v;

        }
    }
}
