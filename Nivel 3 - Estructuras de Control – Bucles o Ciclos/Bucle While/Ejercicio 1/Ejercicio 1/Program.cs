using System;

namespace Ejercicio_1
{
    class Program
    {
        // 1. Suma de los n primeros números.
        static void Main(string[] args)
        {
            int cont,num, suma=0;

            Console.Write("Digite el total de numeros a sumar: ");
            num = Convert.ToInt32(Console.ReadLine());

            cont = 1;
            while (cont <= num)
            {
                suma += cont;
                cont++;
            }
            Console.WriteLine("La suma es: {0}",suma);
            Console.ReadKey();
        }
    }
}
