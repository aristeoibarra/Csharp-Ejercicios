using System;

namespace Ejercicio_2
{
    class Program
    {
        //2. Convertir Grados Celsius a Grados Fahrenheit.
        static void Main(string[] args)
        {
            float gradosCelsious, gradosFahrenheit;

            Console.Write("Digite Grados Celsious: ");
            gradosCelsious = Convert.ToSingle(Console.ReadLine());

            //(0 °C × 9/5) + 32 = 32 °F
            gradosFahrenheit = (gradosCelsious * 9/5) + 32;

            Console.WriteLine("\nGrados Celsious: {0}°C",gradosCelsious);
            Console.WriteLine("Grados Fahrenheit: {0}°F", gradosFahrenheit);
            Console.ReadKey();
        }
    }
}
