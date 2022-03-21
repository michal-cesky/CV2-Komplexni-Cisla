using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_7_2D3D_Object__2_
{
    public class Extremes
    {
        public static T Largest<T>(T[] objects) where T : IComparable
        {
            if (objects.Length == 0) throw new Exception("Cannot find greatest member in an empty array");

            T currentLargest = objects[0];
            for (int i = 1; i < objects.Length; i++)
            {
                if (objects[i].CompareTo(currentLargest) > 0) currentLargest = objects[i];
            }

            return currentLargest;
        }
        public static T Smallest<T>(T[] objects) where T : IComparable
        {
            if (objects.Length == 0) throw new Exception("Cannot find greatest member in an empty array");

            T currentSmallest = objects[0];
            for (int i = 1; i < objects.Length; i++)
            {
                if (objects[i].CompareTo(currentSmallest) < 0) currentSmallest = objects[i];
            }

            return currentSmallest;
        }
    }
}
