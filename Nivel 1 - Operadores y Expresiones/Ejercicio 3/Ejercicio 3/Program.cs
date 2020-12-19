using System;

namespace Ejercicio_3
{
    class Program
    {
        //3. Sacar la hipotenusa de un triángulo rectángulo, pidiendo al usuario el valor de los 2 catetos.
        static void Main(string[] args)
        {
            double cat1, cat2, hipotenusa;

            Console.Write("Digite Cateto 1: ");
            cat1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite Cateto 2: ");
            cat2 = Convert.ToDouble(Console.ReadLine());

            //a^2 + b^2 = c^2
            hipotenusa = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

            Console.WriteLine("\nLa hipotenusa es: {0:N4}", hipotenusa);
            Console.ReadKey();
        }
    }
}
