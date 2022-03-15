using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public abstract class Object3D : GrObject
    {
        public abstract double CalculateSurfaceArea();
        public abstract double CalculateVolume();
    }
}