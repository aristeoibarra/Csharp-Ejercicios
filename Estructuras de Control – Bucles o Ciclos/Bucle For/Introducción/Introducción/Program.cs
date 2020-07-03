using System;

namespace Introducción
{
    class Program
    {
        /* Bucle for: 
           Sintaxis:
           
            for(inicialización; condición; incremento)
            {
                Instrucciones;
                ....
            }
        */
        // Mostrar los 10 primeros numero - Ascendente
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("\tMostrar los 10 primeros numeros - Ascendente");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
