using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Triangle : Object2D
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Triangle(double width, double height)
        {
            if (width < 0 || height < 0) throw new Exception("you cant use negative numbers");
            this.Width = width;
            this.Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Triangle  a={0} x va={1}", Width, Height);
        }
        public override double CalculateArea()
        {
            return (Width * Height)/2;
        }
    }
}
