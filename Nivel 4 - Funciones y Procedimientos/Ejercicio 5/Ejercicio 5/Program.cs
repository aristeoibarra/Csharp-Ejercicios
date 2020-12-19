using System;
using System.ComponentModel.Design;

namespace Ejercicio_5
{
    /*5. Hacer un programa que pida por pantalla una temperatura en grados Celsius,
      muestre un menú para convertirlos a Fahrenheit o Kelvin y muestre el equivalente por pantalla,
      utilizar funciones.
        Celsius a Fahrenheit:
        F = (9*C)/5 + 32;
        Celsius a Kelvin:
        K = C + 273.15;*/
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            int opcion;
            do
            {
                float gradosCelsius;
                Console.Write("Digite una temperatura en grados Celsius: ");
                gradosCelsius = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\n(1) - Convertirlos a Fahrenheit");
                Console.WriteLine("(2) - Convertirlos a Kelvin");
                Console.WriteLine("(3) - Salir");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nGrados Fahrenheit: {0}",CelsiusToFahrenheit(gradosCelsius));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("\nGrados Kelvin: {0}", CelsiusToKelvin(gradosCelsius));
                        Console.WriteLine();
                        break;
                }
            } while (opcion != 3);

           
        }

        static float CelsiusToFahrenheit(float gradosCelsius)
        {
            // F = (9 * C) / 5 + 32;
            return (9 * gradosCelsius) / 5 + 32;
        }
        static float CelsiusToKelvin(float gradosCelsius)
        {
            // K = C + 273.15;
            return gradosCelsius + 273.15f;
        }
    }
}
