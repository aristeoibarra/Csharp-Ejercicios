using System;

namespace Ejercicio_8
{
    class Program
    {
        /*8. Hacer una matriz de tipo entera de 2 * 2, llenarla de números y luego copiar todo
         *   su contenido hacia otra matriz.*/
        static void Main(string[] args)
        {

            int[,] matriz = new int[2, 2];
            int[,] copyMatriz= new int[2,2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Matriz[{i + 1}][{j + 1}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Array.Copy(matriz, copyMatriz, matriz.Length);
            Console.WriteLine();
            ImprimirCopyMatriz(copyMatriz);
            Console.ReadKey();
        }

        private static void ImprimirCopyMatriz(int[,] copyMatriz)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(copyMatriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}