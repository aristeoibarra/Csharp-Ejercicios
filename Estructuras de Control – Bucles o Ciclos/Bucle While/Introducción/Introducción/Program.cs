using System;

namespace Introducción
{
    class Program
    {
        /* La sentecia While
          Sintaxis: 
                    
                   while(condición){
                        instrucciónes;
                   }                        */
        // Mostrar los 10 primeros numeros en pantalla - Ascendente

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
