using System;

namespace Ejercicio_1
{
    class Program
    {
        // 1. Serie Fibonacci con Recursividad: 1.1.2.3.5.8..
        /*
         *  0 1 1 2 3 5 8 .......
         *  fibonacci(1) = 1
         *  fibonacci(n) = fibonacci(n-1)+ fibonacci(n-2)
         */
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite el numero de elementos: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.Write(Fibonacci(i)+ " ,");
            }
            Console.ReadKey();
        }

        private static int Fibonacci(int n)
        {
            if (n == 0 || n ==1)
                return n;
            else
                return (Fibonacci(n-1) + Fibonacci(n-2));
        }
    }
}
