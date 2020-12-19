using System;

namespace Funciones_Matemáticas
{
    class Program
    {
        /* Funciones Matemáticas 
            Math.Ceiling(num2) = Redondea al proximo entero mas cercano
            Math.Abs(num2) = Devuelve el valor absoluto de X
            Math.Floor(num2) = Redondea por defecto al entero mas proximo
            Math.Pow(num1, num2) = Calcula X elevado a la potencia Y
            Math.Sqrt(num2) = Devuelve la raiz cuadrada
            Math.Round(num2) =  Número más cercano a X que contiene varios dígitos
            Math.Max(num1, num2) = Devuelve valor maximo de X/Y
            Math.Min(num1, num2) = Devuelve valor minimo de X/Y
             */
        static void Main(string[] args)
        {
            float num1, num2;

            Console.Write("Digite num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();
            FuncionesMatematicas(num1, num2);
            Console.ReadKey();
        }

        private static void FuncionesMatematicas(float num1, float num2)
        {
            float result;

            result = (float)Math.Ceiling(num2);
            Console.WriteLine("Math.Ceiling: {0}", result);

            result = Math.Abs(num2);
            Console.WriteLine("Math.abs (valor absoluto): {0}", result);

            result = (float)Math.Floor(num2);
            Console.WriteLine("Math.Floor: {0}", result);

            result = (float)Math.Pow(num1, num2);
            Console.WriteLine("Math.Pow: {0}", result);

            result = (float)Math.Sqrt(num2);
            Console.WriteLine("Math.Sqrt: {0}", result);

            result = (float)Math.Round(num2);
            Console.WriteLine("Math.Round: {0}", result);

            result = Math.Max(num1, num2);
            Console.WriteLine("Math.Max: {0}", result);

            result = Math.Min(num1, num2);
            Console.WriteLine("Math.Min: {0}", result);
            Console.WriteLine();
        }
    }
}
