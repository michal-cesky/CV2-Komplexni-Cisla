using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Ellipse : Object2D
    {
        private double axisA;
        private double axisB;

        public Ellipse(double a, double b)
        {
            AxisA = a;
            AxisB = b;
        }

        public double AxisA { get => axisA; set => axisA = value; }
        public double AxisB { get => axisB; set => axisB = value; }

        public override double Area()
        {
            return Math.PI * AxisA * AxisB;
        }

        public override string ToString()
        {
            return String.Format("Ellipse: a = {0}, b = {1}, area = {2:0.00}", AxisA, AxisB, Area());
        }
    }
}
