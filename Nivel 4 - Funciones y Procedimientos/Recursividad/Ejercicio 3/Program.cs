using System;

namespace Ejercicio_3
{
    class Program
    {
        // 3. Pasar de número entero a numero binario con Recursividad.
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Digite un numero entero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero < 0);

            EnteroToBinario(numero);
            Console.ReadKey();
        }

        private static void EnteroToBinario(int n)
        {
            if (n > 1)
                EnteroToBinario(n / 2);
                Console.Write(n%2);
        }
    }
}
