using System;

namespace Funciones_Trigonométricas
{
    class Program
    {
        /*Funciones Trigonométricas
            Math.Acos(x) -> Calcula el arco coseno de x.
            Math.Asin(X) -> Calcula el arco seno de x.
            Math.Atan(x) -> Calcula el arco tangente de x.
            Math.Cos(x) -> Calcula el coseno del angulo x, en radianes
            Math.Sin(X) -> Calcula el seno del angulo x, en radianes
            Math.Tan(x) -> Calcula la tangente del angulo x, en radianes
            */
        static void Main(string[] args)
        {
            float num;

            Console.Write("Digite un numero: ");
            num = Convert.ToSingle(Console.ReadLine());

            FuncionesTrigonométricas(num);
            Console.ReadKey();
        }

        private static void FuncionesTrigonométricas(float x)
        {
            float result;
            result = (float)Math.Acos(x);
            Console.WriteLine("Math.Acos(x) = {0}", result);

            result = (float)Math.Asin(x);
            Console.WriteLine("Math.Asin(x) = {0}", result);

            result = (float)Math.Atan(x);
            Console.WriteLine("Math.Atan(x) = {0}", result);

            result = (float)Math.Cos(x);
            Console.WriteLine("Math.Cos(x) = {0}", result);

            result = (float)Math.Sin(x);
            Console.WriteLine("Math.Sin(x) = {0}", result);

            result = (float)Math.Tan(x);
            Console.WriteLine("Math.Tan(x) = {0}", result);
        }
    }
}
