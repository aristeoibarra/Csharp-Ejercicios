using System;

namespace Ejercicio_10
{
    class Program
    {
        // 10. Factorial de un número.
        static void Main(string[] args)
        {
            int i, numero, factorial=1;

            Console.Write("Digite el numero para hallar el factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = numero; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("\nEl Factorial del num {0} es: {1}",numero,factorial);
            Console.ReadKey();
        }
    }
}
