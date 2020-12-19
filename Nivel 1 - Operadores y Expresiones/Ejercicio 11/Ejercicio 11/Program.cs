using System;

namespace Ejercicio_11
{
    class Program
    {
        // 11. Calcular la cantidad de segundos que están incluidos en 
        // el número de horas, minutos y segundos ingresados por el usuario.
        static void Main(string[] args)
        {
            const int MIN = 60;
            const int HRS = 3600;

            int horas, minutos, segundos;

            Console.Write("Ingrese Num. Horas: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Num. Minutos: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese Num. Segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            horas *= HRS;
            minutos *= MIN;
            segundos += horas + minutos;

            Console.WriteLine("\nCantidad de segundos: {0}sg",segundos);
            Console.ReadKey();
        }
    }
}