using System;

namespace Ejercicio_4
{
    class Program
    {
        // 4. Determinar si un número es par, impar.
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite un numero Entero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if((num % 2)== 0)
                Console.WriteLine("\nEl numero es PAR");
            else
                Console.WriteLine("\nEl numero es IMPAR");

            Console.ReadKey();
        }
    }
}
