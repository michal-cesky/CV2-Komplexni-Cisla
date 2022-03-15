using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Sphere : Object3D
    {
        public double r { get; private set; }

        public Sphere(double radius)
        {
            if (radius < 0 ) throw new Exception("you cant use negative numbers");
            this.r = radius;


        }
        public override void Draw()
        {
            Console.WriteLine("\nSphere  r={0} ", r);
        }
        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * r * r;
        }

        public override double CalculateVolume()
        {
            return (4/3) *Math.PI * r * r * r;

        }
    }
}
