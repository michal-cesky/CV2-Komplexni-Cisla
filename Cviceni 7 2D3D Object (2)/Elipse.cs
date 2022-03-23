using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Ellipse : Object2D
    {
        private double a;
        private double b;

        public Ellipse(double edgeA, double edgeB)
        {
            this.a = edgeA;
            this.b = edgeB;
        }

        public double edgeA { get => a; set => a = value; }
        public double edgeB { get => b; set => b = value; }

        public override double Area()
        {
            return Math.PI * a * b;
        }

        public override string ToString()
        {
            return String.Format("Ellipse: a = {0}, b = {1}, area = {2:0.00}", a, b, Area());
        }
    }
}
