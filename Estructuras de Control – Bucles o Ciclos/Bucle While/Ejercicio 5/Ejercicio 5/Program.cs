using System;

namespace Ejercicio_5
{
    //  5. Sumar 1-2+3-4...

    /*
     Impares (+)
     Pares (-)

         sumaPares = -2 -4 -6 -8
         sumaImpares= 1 + 3 + 5 + 7

         sumaTotal = sumaImpares + sumaPares;
    */
    class Program
    {
        static void Main(string[] args)
        {
            int i, sumaPares = 0, sumaImpares = 0, hasta;

            Console.Write("Digite el total de elementos a sumar: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= hasta)
            {
                if (i % 2 == 0)
                {
                    int ne = i * (-1);
                    sumaPares += ne;
                }
                else
                {
                    sumaImpares += i;       
                }
                i++;
            }

            int sumaTotal = sumaImpares + sumaPares;
            Console.WriteLine("\nLa suma total es: {0}", sumaTotal);
            Console.ReadKey();
        }
    }
}
