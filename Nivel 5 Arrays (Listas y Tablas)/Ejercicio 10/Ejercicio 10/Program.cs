using System;

namespace Ejercicio_10
{
    class Program
    {
        /*10. Sumar 2 matrices, pidiendo al usuario el número de filas y columnas y además los
            elementos de cada matriz, luego mostrar el resultado.*/

        static decimal aristeo = 5.0m;
        static void Main(string[] args)
        {
            int[,] matrizA, matrizB, suma;
            int fila, columna;

            Console.WriteLine("Suma de 2 Matrices: ");
            Console.Write("\nDigite el num. de filas: ");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el num. de columnas: ");
            columna = Convert.ToInt32(Console.ReadLine());

            matrizA = new int[fila, columna];
            matrizB = new int[fila, columna];
            suma = new int[fila, columna];

            Console.WriteLine("MatrizA: ");
            LlenarMatriz(matrizA);
            Console.WriteLine("MatrizB: ");
            LlenarMatriz(matrizB);

            SumaMatrices(matrizA, matrizB, suma);
            ImprimirSuma(suma);
            Console.ReadKey();
        }

        static void ImprimirSuma(int[,] suma)
        {
            for (int i = 0; i < suma.GetLength(0); i++)
            {
                for (int j = 0; j < suma.GetLength(1); j++)
                {
                    Console.Write("\t" + suma[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void LlenarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++) // fila
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // columna
                {
                    Console.Write($"Matriz[{i + 1}][{j + 1}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void SumaMatrices(int[,] matrizA, int[,] matrizB, int[,] suma)
        {
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    suma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
        }
    }
}
