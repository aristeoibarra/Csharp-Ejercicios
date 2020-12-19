using System;

namespace Ejercicio_2
{
    // 2. Hacer un programa que realice la media aritmética de 2 números.
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado;

            Console.Write("Digite num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            resultado = mediaAritmetica(num1, num2);
            Console.WriteLine("La media aritmetica de {0} y {1} es: {2}",num1,num2,resultado);
            Console.ReadKey();
        }

        private static float mediaAritmetica(float num1, float num2)
        {
            return (num1 + num2) / 2;
        }
    }
}
