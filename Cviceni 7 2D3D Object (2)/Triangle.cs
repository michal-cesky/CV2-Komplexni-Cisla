using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Triangle : Object2D
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double EdgeA, double EdgeB, double EdgeC)
        {
                this.a = EdgeA;
                this.b = EdgeB;
                this.c = EdgeC;
        }

        public double EdgeA { get => a; set => a = value; }
        public double EdgeB { get => b; set => b = value; }
        public double EdgeC { get => c; set => c = value; }

        public override double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override string ToString()
        {
            return String.Format("Triangle: a = {0}, b = {1}, c = {2}, area = {3:0.00}", a, b, c, Area());
        }
    }
}
