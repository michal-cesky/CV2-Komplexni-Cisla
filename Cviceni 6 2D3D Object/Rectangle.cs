using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Rectangle : Object2D
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0) throw new Exception("you cant use negative numbers");
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Rectangle ({0} x {1})", Width, Height);
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}