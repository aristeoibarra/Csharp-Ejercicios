using System;

namespace Ejercicio_4
{
    class Program
    {
        // 4. Múltiplos de 5 desde 1 hasta n.
        static void Main(string[] args)
        {
            int i , hasta;

            Console.WriteLine("\tMultiplos de 5");
            Console.Write("Hasta que numero: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            i = 1;
            while (i <= hasta)
            {
                if (i % 5 == 0)
                    Console.WriteLine($"{i}.");
                i++;
            }
            Console.ReadKey();
        }
    }
}