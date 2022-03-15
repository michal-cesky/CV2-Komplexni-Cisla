using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObject[] Objects = new GrObject[]
            {
                new Circle(10), new Rectangle(10, 5), new Ellipse(10, 5), new Triangle(5, 2), new Block(5, 5, 5), new Cilinder(5, 5), new Sphere(5), new Piramid(5, 5)
            };
            foreach (GrObject CurrentObject in Objects)
            {
                CurrentObject.Draw();
                if (CurrentObject is Object2D)
                {
                    Console.WriteLine("Object area: {0:F2}\n", ((Object2D)CurrentObject).CalculateArea());
   
                }
                if (CurrentObject is Object3D)
                {
                    Console.WriteLine("Object surface area: {0:F2}", ((Object3D)CurrentObject).CalculateSurfaceArea());
                    Console.WriteLine("Object volume area: {0:F2}", ((Object3D)CurrentObject).CalculateVolume());
                }
            }
            Console.ReadLine();
        }
    }
}