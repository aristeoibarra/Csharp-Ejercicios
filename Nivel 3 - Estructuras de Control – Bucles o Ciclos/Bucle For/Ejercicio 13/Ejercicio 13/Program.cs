using System;

namespace Ejercicio_13
{
    class Program
    {
        // 13. Hacer un programa que imprima la suma de todos los números pares 
        // que hay desde 1 hasta n, y diga cuantos números hay.
        static void Main(string[] args)
        {
            int i, hasta,sumaPares=0;

            Console.Write("Hasta: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= hasta; i++)
            {
                if (i % 2 == 0)
                    sumaPares += i;
            }
            Console.WriteLine("\nLa suma es: {0}",sumaPares);
            Console.ReadKey();
        }
    }
}
