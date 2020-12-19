using System;

namespace Ejercicio_4
{
    class Program
    {
        // 4. Hacer un Programa que calcule longitudes de Circunferencia.
        static void Main(string[] args)
        {
            double longitud, radio;

            Console.Write("Digite el Radio: ");
            radio = Convert.ToSingle(Console.ReadLine());

            // L = 2 x PI x radio
            longitud = 2 * Math.PI * radio;

            Console.WriteLine("\nLa longitud de la circunferencia es: {0:N3}",longitud);
            Console.ReadKey();
        }
    }
}
