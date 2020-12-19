using System;

namespace Ejercicio_1
{
    class Program
    {
        // 1. Copiar el contenido de un Array1 de 5 elementos hacia otro Array2.
        static void Main(string[] args)
        {
            // Tipo de dato []  nombre = new tipo de dato [#-de_elementos];

            int[] array1 = new int[] { 2, 4, 6, 8, 14 };
            int[] array2 = new int[array1.Length];

            CopiandoArrays(array1,array2);

            Console.WriteLine("Array1");
            MostrarArray1(array1);
           
            Console.WriteLine("\nArray2");
            MostrarArray2(array2);
            Console.ReadKey();
        }

        static void CopiandoArrays(int[] array1, int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }
        }
        static void MostrarArray1(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
        static void MostrarArray2(int[] array2)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
        }
    }
}
