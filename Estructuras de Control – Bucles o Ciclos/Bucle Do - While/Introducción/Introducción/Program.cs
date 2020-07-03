using System;

namespace Introducción
{
    class Program
    {
        /*
          Repetición: El bucle do...While
            Sintaxis:
                    
                    do{
                        Instrucciónes;
                        ....
                    }while(condición)
        */
        // Mostrar los 10 primeros numeros 
        // Saludo
        static void Main(string[] args)
        {
            int i=1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            Console.WriteLine("------------------");

            char opc;
            do
            {
                Console.WriteLine("Hola");
                Console.Write("\nDigite 's' para saludar nuevamente: ");
                opc = Convert.ToChar(Console.ReadLine());
            } while (opc == 's' || opc == 'S');

            Console.ReadKey();
        }
    }
}
