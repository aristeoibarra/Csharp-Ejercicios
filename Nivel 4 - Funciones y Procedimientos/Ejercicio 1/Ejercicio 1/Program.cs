using System;

namespace Ejercicio_1
{
    class Program
    {
        // 1. Determinar si un número es par o no.
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (Comprobar(numero) == true)
                Console.WriteLine("\nEl numero {0} es PAR", numero);
            else
                Console.WriteLine("\nEl numero {0} es IMPAR", numero);
            Console.ReadKey();
        }

        static bool Comprobar(int numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
