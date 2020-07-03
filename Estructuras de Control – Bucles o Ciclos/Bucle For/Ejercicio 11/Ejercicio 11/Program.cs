using System;
using System.Globalization;

namespace Ejercicio_11
{
    class Program
    {
        // 11. Suma de factoriales
        static void Main(string[] args)
        {
            int i,numero ,sumaFactorial=0, factorial=1;

            Console.Write("Digite el numero a calcular: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numero; i++)
            {
                factorial *= i;
                sumaFactorial += factorial;
            }

            Console.WriteLine("\nLa suma de factoriales es: {0}", sumaFactorial);
            Console.ReadKey();
        }
    }
}
