using System;

namespace Ejercicio_2
{
    class Program
    {
        // 2. Comprobar si un número digitado por el usuario es positivo o negativo.
        static void Main(string[] args)
        {
            float num;

            Console.Write("Digite un Numero: ");
            num = Convert.ToSingle(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("\nEl numero es NEGATIVO");
            else
                Console.WriteLine("\nEl numero es POSITIVO");

            Console.ReadKey();
        }
    }
}