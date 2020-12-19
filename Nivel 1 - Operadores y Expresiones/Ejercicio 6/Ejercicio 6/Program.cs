using System;

namespace Ejercicio_6
{
    class Program
    {
        //6. Calcule la media aritmética de 3 números cualesquiera.
        static void Main(string[] args)
        {
            float num1, num2, num3, mediaAritmética;

            Console.Write("Digite num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite num3: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            mediaAritmética = (num1 + num2 + num3) / 3;

            Console.WriteLine("\nLa media aritmética es: {0}",mediaAritmética);
            Console.ReadKey();
        }
    }
}
