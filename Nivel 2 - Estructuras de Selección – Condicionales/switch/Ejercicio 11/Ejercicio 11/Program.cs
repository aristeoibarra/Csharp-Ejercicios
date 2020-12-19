using System;

namespace Ejercicio_11
{
    class Program
    {
        /* 11. Dada una nota de un examen mediante un código escribir el literal que le corresponde a la nota:
                A - Excelente 
                B - Notable   
                C - Aprobado  
                D y F – Reprobado.
        */
        static void Main(string[] args)
        {
            char notaExamen;

            Console.Write("Ingrese nota del EXAMEN: ");
            notaExamen =Convert.ToChar(Console.ReadLine());

            switch (notaExamen)
            {
                case 'A': Console.WriteLine("\n(A) - Excelente"); break;
                case 'B': Console.WriteLine("\n(B) - Notable"); break;
                case 'C': Console.WriteLine("\n(C) - Aprobado"); break;
                case 'D': case 'F': Console.WriteLine("\n({0}) - Reprobado",notaExamen); break;
                default: Console.WriteLine("\nNota no valida");break;
            }
            Console.ReadKey();
        }
    }
}
