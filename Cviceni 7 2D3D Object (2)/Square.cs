using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Square : Object2D
    {
        private double a;

        public Square(double edgeA)
        {
            this.a = edgeA;
        }

        public double EdgeA { get => a; set => a = value; }

        public override double Area()
        {
            return Math.Pow(a, 2);
        }

        public override string ToString()
        {
            return String.Format("Square: a = {0}, area = {1:0.00}", a, Area());
        }
    }
}
