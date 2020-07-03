using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 60;
            int horas, segundos;

            Console.Write("Digite los Segundos: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            horas = segundos / MIN;
            segundos %= MIN;

            Console.WriteLine("\nHoras: {0} hrs", horas);
            Console.Write("Segundos: {0} sg", segundos);
            Console.ReadKey();
        }
    }
}
