using System;

namespace Función_Recursiva
{
    class Program
    {
        /*Recursividad: Una función recursiva es una función que se llama as si misma.
             1. Caso Base.
             2. Caso Recursivo ó inductivo.

            a(x){
                if(n==1)
                    return n;
                else
                    a(x);
        */
        // Factorial        
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEl factorial de numero es: {0}", Factorial(numero));
            Console.ReadKey();
        }

        static long Factorial(int numero)
        {
            if (numero == 1) // Caso Base.
                return 1;
            else // Caso Recursivo ó inductivo.
                return (numero * Factorial(numero - 1));
        }
    }
}
