using System;

namespace Ejercicio_10
{
    class Program
    {
        /*
         Un alumno desea saber cuál será su calificación final en la materia de Algoritmos. 
          Dicha calificación se compone de los siguientes porcentajes:
            • 55% del promedio de sus tres calificaciones parciales.
            • 30% de la calificación del examen final.
            • 15% de la calificación de un trabajo final.
        */
        static void Main(string[] args)
        {
            const int PARCIALES = 55;
            const int EXAMEN_FINAL = 30;
            const int TRABAJO_FINAL = 15;
            
            float califParciales, califExamenFinal, califTrabajoFinal,califFinal, aux;
            int par1, par2, par3;

            Console.Write("Calificación de parcial 1: ");
            par1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Calificación de parcial 2: ");
            par2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Calificación de parcial 3: ");
            par3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCalificación examen final: ");
            califExamenFinal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calificación trabajo final: ");
            califTrabajoFinal = Convert.ToInt32(Console.ReadLine());

            aux = (par1 + par2 + par3) / 3;
            califParciales = aux * (PARCIALES / 100.0f);
            califExamenFinal *= EXAMEN_FINAL / 100.0f;
            califTrabajoFinal *= TRABAJO_FINAL / 100.0f;

            califFinal = califParciales + califExamenFinal + califTrabajoFinal;

            Console.WriteLine("\n(55%) Parciales: {0}%", califParciales);
            Console.WriteLine("(30%) Examen Final: {0}%", califExamenFinal);
            Console.WriteLine("(15%) Trabajo Final: {0}%", califTrabajoFinal);
            Console.WriteLine("\nCalificación final: {0}%", califFinal);
            Console.ReadKey();
        }
       
    }
}

