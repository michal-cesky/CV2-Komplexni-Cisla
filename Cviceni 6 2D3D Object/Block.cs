using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Block : Object3D
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }
        public Block(double width, double height, double depth)
        {
            if (width < 0 || height < 0 || depth <0) throw new Exception("you cant use negative numbers");
            this.a = width;
            this.b = height;
            this.c = depth;

        }
        public override void Draw()
        {
            Console.WriteLine("Block  a={0} x b={1} c={2}", a, b, c);
        }
        public override double CalculateSurfaceArea()
        {
            return 2 * (a * b + a * c + b * c);
        }

        public override double CalculateVolume()
        {
            return a * b *c;

        }
    }
}
