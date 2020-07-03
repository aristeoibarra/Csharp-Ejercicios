using System;

namespace Ejercicio_1
{
    class Program
    {
        //1. Pedir 2 números al usuario y sumarlos, restarlos, multiplicarlos y dividirlos.
        static void Main(string[] args)
        {
            float num1, num2;

            Console.Write("Digite num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nLa suma es: {0}",(num1 + num2));
            Console.WriteLine("La resta es: {0}", (num1 - num2));
            Console.WriteLine("La multiplicación es: {0}", (num1 * num2));

            if (num2 != 0)
                Console.WriteLine("La división es: {0}",(num1 / num2));
            else
                Console.WriteLine("No se puede llevar acabo la división");

            Console.ReadKey();
        }
    }
}
