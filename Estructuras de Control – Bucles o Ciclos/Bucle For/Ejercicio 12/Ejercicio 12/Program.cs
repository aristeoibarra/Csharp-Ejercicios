using System;

namespace Ejercicio_12
{
    class Program
    {
        // 12. Serie Fibonacci: 1 1 2 3 5 8 13...
        static void Main(string[] args)
        {
            int x=0, y=1, z=1, hasta;

            Console.Write("Digite el numero de elementos: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hasta; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.Write($"{z} ,");
            }
            Console.ReadKey();

        }
    }
}
