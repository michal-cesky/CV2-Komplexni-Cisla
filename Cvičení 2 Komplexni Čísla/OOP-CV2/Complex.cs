using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CV2
{
    class Complex
    {
        public double Real;
        public double Imaginary;
        public Complex(double real = 0.0, double imaginary = 0.0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary), (a.Imaginary * b.Real - a.Real * b.Imaginary) / (b.Real * b.Real + b.Imaginary * b.Imaginary));
        }


        public static Complex Associated(Complex a)
        {
            return new Complex(a.Real, -a.Imaginary);
        }


        /*public double (Complex a, Complex b)
        {
           if (a.Imaginary < 0)
            {
                return new Complex(a.Real, b.Real * -1);
            }
        }*/

        public static bool operator !=(Complex a, Complex b)
        {
            if (a.Real != b.Real && a.Imaginary != b.Imaginary)

                return true;
            else
                return false;

        }

        public static bool operator ==(Complex a, Complex b)
        {
            if (a.Real == b.Real && a.Imaginary == b.Imaginary)

                return false;
            else
                return true;
        }

        public static double ModulA(Complex a)
        {
            return Math.Sqrt(a.Real * a.Real + a.Imaginary * a.Imaginary);
        }

        public static double ModulB(Complex b)
        {
            return Math.Sqrt(b.Real * b.Real + b.Imaginary * b.Imaginary);
        }

        public static double Argument(Complex a)
        {
            return Math.Sqrt(a.Real * a.Real + a.Imaginary * a.Imaginary);
        }


        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return string.Format("{0}-{1}j", Real, -Imaginary);
            }
            else
            {
                return string.Format("{0}+{1}j", Real, Imaginary);
            }
        }

    }
}