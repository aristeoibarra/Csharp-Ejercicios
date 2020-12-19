using System;

namespace Ejercicio_2
{
    class Program
    {
        // 2. Consideremos una función que recibe un número n
        //    e imprime los números del n al 1. Con recursividad.
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine(ImprimirNumeros(i));
            }
            Console.ReadKey();
        }
        
        static int ImprimirNumeros(int num)
        {
            if (num == 1 || num==0)
                return 1;
            else
                return ImprimirNumeros(num-1)+1;
        }
    }
}
