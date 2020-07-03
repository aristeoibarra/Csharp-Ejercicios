using System;

namespace Ejercicio_3
{
    class Program
    {
        // 3. Múltiplos de 3 desde 1 hasta n.
        static void Main(string[] args)
        {
            int i = 1, hasta;

            Console.WriteLine("\tMultiplos de 3");
            Console.Write("Hasta que numero: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            while (i <= hasta)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"{i}.");
                i++;
            }
            Console.ReadKey();
        }
    }
}
