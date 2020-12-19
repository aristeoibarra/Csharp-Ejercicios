using System;

namespace Ejercicio_9
{
    class Program
    {
        // 9. Sumar 2 matrices
        // A+B , B+C , A+C, A+B+C

        static int[,] sumaMatriz = new int[3,3];
        static void Main(string[] args)
        {
            int[,] A = new int[3, 3] { { -5, 10, 0 }, { 2, -14, 9 }, { -6, 3, 8 } };
            int[,] B = new int[3, 3] { { -8, 3, 4 }, { -9, 7, -5 }, { 15, -3, 0 } };
            int[,] C = new int[3, 3] { { 5, 0, 2 }, { -4, 6, 10 }, { 0, -5, 1 } };

            Console.WriteLine("A + B :");
            SumarMatriz3x3(A, B);
            ImprimirSumaMatriz(sumaMatriz);

            Console.WriteLine("\nB + C :");
            SumarMatriz3x3(B, C);
            ImprimirSumaMatriz(sumaMatriz);

            Console.WriteLine("\nA + C :");
            SumarMatriz3x3(A, C);
            ImprimirSumaMatriz(sumaMatriz);

            Console.WriteLine("\nA + B + C :");
            SumarMatriz3x3(A, B, C);
            ImprimirSumaMatriz(sumaMatriz);

            Console.ReadKey();
        }

        private static void SumarMatriz3x3(int[,] a, int[,] b)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumaMatriz[i,j] = a[i, j] + b[i, j];
                }
            }
        }

        private static void SumarMatriz3x3(int[,] a, int[,] b, int[,] c)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sumaMatriz[i, j] = a[i, j] + b[i, j] + c[i,j];
                }
            }
        }

        private static void ImprimirSumaMatriz(int[,] sumaMatriz)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + sumaMatriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
