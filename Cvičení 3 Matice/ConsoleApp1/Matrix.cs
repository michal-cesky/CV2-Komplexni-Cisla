using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cviceni_3
{
    public class Matrix
    {
        public double[,] Matice;


        public Matrix(double[,] matrix)
        {
            Matice = matrix;

        }

        public static Matrix operator +(Matrix a, Matrix b) 
        {
            try
            {
              

                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        mtx.Matice[i, j] = a.Matice[i, j] + b.Matice[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                Console.WriteLine("MAtice nebylo mozno secist");

            }

            return a;
        }

        public static Matrix operator -(Matrix a, Matrix b) 
        {
            try
            {
                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        mtx.Matice[i, j] = a.Matice[i, j] - b.Matice[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                Console.WriteLine("Matice nebylo mozno odecist");

            }

            return a;
        }

        public static Matrix operator *(Matrix a, Matrix b) 
        {
            try
            {
                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                            mtx.Matice[i, j] = 0;
                            for (int k = 0; k < a.Matice.GetLength(1); k++) 
                                mtx.Matice[i, j] = mtx.Matice[i, j] + a.Matice[i, k] * b.Matice[k, j];
                        }

                    }
                    return mtx;
                
            }
            catch
            {
                Console.WriteLine("Matice nebylo mzne vynasobit");

            }

            return a;
        }
    
       /* public static bool operator ==(Matrix a, Matrix b)
        {
            return a == b;
        }
        public static bool operator !=(Matrix a, Matrix b) //Pro operator == musim definovat take !=
        {
            return !(a == b); //Uz mam definovano v opeeratoru ==
        }
        public static Matrix operator -(Matrix a) //Unarni operator -
        {
            return new Matrix();
        }
        public Matrix Determinant() //Vraci determinant matice
        {
            return new Matrix();
        }*/


        public override string ToString() //Vypis do retezce
        {
            var row = Matice.GetLength(0); 

            var columm = Matice.GetLength(1);
             
            string output = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columm; j++)
                {
                    if (j != row ) output += $"{Matice[i, j]} ";
                }
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
