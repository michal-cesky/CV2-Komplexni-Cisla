using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Rectangle : Object2D
    {
        private double a;
        private double b;

        public Rectangle(double width, double height)
        {
            this.a = width;
            this.b = height;
        }

        public double EdgeA { get => a; set => a = value; }
        public double EdgeB { get => b; set => b = value; }

        public override double Area()
        {
            return a * b;
        }

        public override string ToString()
        {
            return String.Format("Rectangle: a = {0}, b = {1}, area = {2:0.00}", EdgeA, EdgeB, Area());
        }
    }
}
