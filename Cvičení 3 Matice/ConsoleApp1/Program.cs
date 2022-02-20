using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Cviceni_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] mat1 = new double[,] {
                { 1, 5, 5 },
                { 3, 4, 5 },
                { 5, 6, 5 },


            };
            double[,] mat2 = new double[,] {
                { 1, 5, 5 },
                { 3, 4, 5 },
                { 5, 6, 7 },
            };

            Matrix m1 = new Matrix(mat1);
            Matrix m2 = new Matrix(mat2);

            Console.WriteLine("Add:");
            Console.WriteLine( m1 + m2);
            Console.WriteLine("Subtraction:");
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.ReadLine();


        }
    }
}
