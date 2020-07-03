using System;

namespace Ejercicio_6
{
    class Program
    {
        // 6. Sumar pares desde n hasta m.
        static void Main(string[] args)
        {
            int sumaPares=0, desde, hasta;

            Console.WriteLine("\tSumar pares desde n hasta m.");
            Console.Write("Desde: ");
            desde = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hasta: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            while (desde <= hasta)
            {
                if (desde % 2 == 0)
                    sumaPares += desde;
                desde++;
            }

            Console.WriteLine("\nLa suma total es: {0}",sumaPares);
            Console.ReadKey();
        }
    }
}
