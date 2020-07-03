using System;

namespace Ejercicio_12
{
    class Program
    {
        /*12. Seleccionar un tipo de vehículo e indicar el peaje a pagar según un valor numérico
                1 - turismo, peaje = $500.
                2 - autobús, peaje = $3000.
                3 - motocicleta, peaje = $300.
                Caso contrario - Vehículo no autorizado.
        */
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("(1) - turismo");
            Console.WriteLine("(2) - autobús");
            Console.WriteLine("(3) - motocicleta");
            Console.Write("Selecciona el tipo de vehiculo: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("\nTurismo, peaje = $500"); break;
                case 2: Console.WriteLine("\nAutobús, peaje = $3000");break;
                case 3: Console.WriteLine("\nMotocicleta, peaje = $300");break;
                default: Console.WriteLine("\nVehículo no autorizado"); break;
            }
            Console.ReadKey();
        }
    }
}
