using System;

namespace Ejercicio_4
{
    class Program
    {
        /*4. Hacer 2 arrays de cadenas de caracteres, almacenar 2 nombres cada uno dentro de su respectiva variable,
         * y luego intercambiar el contenido de los arrays.*/
        static void Main(string[] args)
        {
            string[] arrayNombre1 = new string[2];
            string[] arrayNombre2 = new string[2];

            Console.WriteLine("arrayNombre1");
            LlenarArreglo(arrayNombre1);

            Console.WriteLine("\narrayNombre2");
            LlenarArreglo(arrayNombre2);

            IntercambiarArray(arrayNombre1, arrayNombre2);

            Console.WriteLine("\nMostrar arrayNombre1");
            ImprimirArray(arrayNombre1);

            Console.WriteLine("\nMostrar arrayNombre2");
            ImprimirArray(arrayNombre2);

            Console.ReadKey();
        }

        static void LlenarArreglo(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Nombre[{0}]: ", (i + 1));
                array[i] = Console.ReadLine();
            }
        }

        static void IntercambiarArray(string[] a, string[] b)
        {
            string[] temp1 = new string[2];
            string[] temp2 = new string[2];

            a.CopyTo(temp1, 0);
            b.CopyTo(temp2,0);

            for (int i = 0; i < 2; i++)
            {
                a[i] = temp2[i];
                b[i] = temp1[i];
            }
        }

        static void ImprimirArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
