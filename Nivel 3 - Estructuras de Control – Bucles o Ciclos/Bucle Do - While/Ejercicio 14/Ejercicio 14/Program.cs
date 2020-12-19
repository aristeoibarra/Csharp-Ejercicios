using System;

namespace Ejercicio_14
{
    class Program
    {
        // 14. Hacer un bucle do...while para imprimir las letras minúsculas del alfabeto.
        static void Main(string[] args)
        {
            char i = 'a';

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 'z');
            
            Console.ReadKey();
        }
    }
}
