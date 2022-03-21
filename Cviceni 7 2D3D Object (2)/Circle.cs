using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Circle : Object2D
    {
        private double r;

        public Circle(double radius)
        {
            this.r = radius;
        }

        public double Radius { get => r; set => r = value; }

        public override double Area()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override string ToString()
        {
            return String.Format("Circle: radius = {0}, area = {1:0.00}", r, Area());
        }
    }
}
