using System;

namespace Ejercicio_7
{
    class Program
    {
        // 7. Suma de los 10 primeros números pares.
        static void Main(string[] args)
        {
            int i, sumaPares=0;

            for (i = 0; i <= 10; i+=2)
            {
                    sumaPares += i;
            }
            Console.WriteLine("La suma de los 10 primeros números pares es: {0}",sumaPares);
            Console.ReadKey();
        }
    }
}
