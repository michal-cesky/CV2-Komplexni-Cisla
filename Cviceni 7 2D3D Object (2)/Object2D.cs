using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public abstract class Object2D : I2D, IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Object2D obj2d = obj as Object2D;
            if (obj2d != null)
                return Area().CompareTo(obj2d.Area());

            else
                throw new ArgumentException("Objects not comparable.");
        }

        public abstract double Area();
    }
}
