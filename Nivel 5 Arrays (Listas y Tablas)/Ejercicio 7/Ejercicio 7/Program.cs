using System;

namespace Ejercicio_7
{
    class Program
    {
        /*7. Hacer una matriz de tipo entera preguntándole
         * al usuario el número de filas y el número de columnas,
         * rellenar la matriz y luego mostrarla en pantalla.*/
        static void Main(string[] args)
        {

            /*   MATRIZ
                C0 1 2 3 4 
             F0| 5 2 9 1 7 
              1| 4 1 8 2 8 
              2| 3 0 7 3 9 
              3| 2 1 6 4 6 
            */
            int[,] matriz;
            int fila, columna;

            Console.WriteLine("Matriz");
            Console.Write(" Numero de filas: ");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Numero de columnas: ");
            columna = Convert.ToInt32(Console.ReadLine());

            matriz = new int[fila,columna];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write("Matriz[{0}][{1}]: ", i, j);
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            MostrarMatriz(matriz, fila, columna);
            Console.ReadKey();
        }

        private static void MostrarMatriz(int[,] matriz,int fila , int columna)
        {
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
