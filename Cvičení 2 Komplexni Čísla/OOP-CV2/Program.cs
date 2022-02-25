using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(1.2, -0.5); // vytvoření instance třídy
            Complex y = new Complex(2.0, -1.5); // vytvoření instance třídy
            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(Complex.Associated(x));
            Console.WriteLine(Complex.ModulA(x));
            Console.WriteLine(Complex.ModulB(y));
            Console.ReadLine();
        }
    }
}
