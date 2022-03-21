using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Triangle : Object2D
    {
        private double edgeA;
        private double edgeB;
        private double edgeC;

        public Triangle(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }

            else
                throw new ArgumentException("Not a triangle."); ;
        }

        public double EdgeA { get => edgeA; set => edgeA = value; }
        public double EdgeB { get => edgeB; set => edgeB = value; }
        public double EdgeC { get => edgeC; set => edgeC = value; }


        // Heron's formula (https://en.wikipedia.org/wiki/Heron%27s_formula)
        public override double Area()
        {
            double s = (EdgeA + EdgeB + EdgeC) / 2;
            return Math.Sqrt(s * (s - EdgeA) * (s - EdgeB) * (s - EdgeC));
        }

        public override string ToString()
        {
            return String.Format("Triangle: a = {0}, b = {1}, c = {2}, area = {3:0.00}", EdgeA, EdgeB, EdgeC, Area());
        }
    }
}
