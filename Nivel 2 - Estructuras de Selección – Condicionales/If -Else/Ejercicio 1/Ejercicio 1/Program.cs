using System;

namespace Ejercicio_1
{
    class Program
    {
        // 1. Comprobar a través de un programa si un alumno aprobó o no un examen
        // (Aprueba si su nota es mayor a 69).
        static void Main(string[] args)
        {
            float CalifExamen;

            Console.Write("Dgite calif. del Examen: ");
            CalifExamen = Convert.ToSingle(Console.ReadLine());

            if(CalifExamen < 0 || CalifExamen > 100)
                Console.WriteLine("\nError al calcular");
            else if (CalifExamen > 69)
                Console.WriteLine("\nEl alumno aprobado");
            else
                Console.WriteLine("\nEl alumno reprobado");            
            Console.ReadKey();
        }
    }
}