using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cviceni_3
{
    public class Matrix
    {
        public double[,] matrix1;


        public Matrix(double[,] matrix)
        {
            matrix1 = matrix;

        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            try
            {


                var mtx = new Matrix(new double[a.matrix1.GetLength(0), a.matrix1.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix1.GetLength(1); j++)
                    {
                        mtx.matrix1[i, j] = a.matrix1[i, j] + b.matrix1[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                throw new InvalidCastException();

            }

           
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            try
            {
                var mtx = new Matrix(new double[a.matrix1.GetLength(0), a.matrix1.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix1.GetLength(1); j++)
                    {
                        mtx.matrix1[i, j] = a.matrix1[i, j] - b.matrix1[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                throw new InvalidCastException();

            }

            
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            try
            {
                var mtx = new Matrix(new double[a.matrix1.GetLength(0), a.matrix1.GetLength(1)]);          //0 sloiupec, 1 řádek
                for (int i = 0; i < a.matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix1.GetLength(1); j++)
                    {
                        mtx.matrix1[i, j] = 0;
                        for (int k = 0; k < a.matrix1.GetLength(1); k++)
                            mtx.matrix1[i, j] = mtx.matrix1[i, j] + a.matrix1[i, k] * b.matrix1[k, j];
                    }

                }
                return mtx;

            }
            catch
            {
                throw new InvalidCastException();

            }

           
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix1.GetLength(1); j++)
                {
                    if (a.matrix1[i, j] == b.matrix1[i, j])
                    {
                        return true;
                    }

                }

            }
            return false;


        }

        public static bool operator !=(Matrix a, Matrix b)
        {

                for (int i = 0; i < a.matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix1.GetLength(1); j++)
                    {
                        if (a.matrix1[i, j] != b.matrix1[i, j])
                        {
                        return false;
                        }

                    }
                    
                }
            return true;
   


        }

        public static Matrix Associated(Matrix a)
        {

            var mtx = new Matrix(new double[a.matrix1.GetLength(0), a.matrix1.GetLength(1)]);
            for (int i = 0; i < a.matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix1.GetLength(1); j++)
                {
                    mtx.matrix1[i, j] = a.matrix1[i, j] * (-1);

                }


            }
            return mtx;

        }


        public double Determinant()
        {
            if (matrix1.GetLength(0) == matrix1.GetLength(1) && matrix1.GetLength(1) == 1)
            {
                return matrix1[0, 0];

            }
            else if (matrix1.GetLength(0) == matrix1.GetLength(1) && matrix1.GetLength(1) == 2)
            {
                return (matrix1[0, 0] * matrix1[1, 1]) - (matrix1[0, 1] * matrix1[1, 0]);

            }
            else if (matrix1.GetLength(0) == matrix1.GetLength(1) && matrix1.GetLength(1) == 3)
            {
                return matrix1[0, 0] * (matrix1[1, 1] * matrix1[2, 2] - matrix1[1, 2] * matrix1[2, 1]) -
               matrix1[0, 1] * (matrix1[1, 0] * matrix1[2, 2] - matrix1[1, 2] * matrix1[2, 0]) +
                matrix1[0, 2] * (matrix1[1, 0] * matrix1[2, 1] - matrix1[1, 1] * matrix1[2, 0]);
            }
            else
            {
                throw new InvalidCastException();
            }

        }


        public override string ToString() //Vypis do retezce
        {
            var row = matrix1.GetLength(0);

            var columm = matrix1.GetLength(1);

            string output = "";
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < columm; j++)
                {
                    if (j != row) output += $"{matrix1[i, j]}\t ";
                }
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
