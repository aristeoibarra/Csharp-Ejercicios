using System;

namespace Ejercicio_2
{
    class Program
    {
        //2. Digite un número, si el número supera a 10, multiplique los 10 primeros números,
        //   sino, súmelos.
        static void Main(string[] args)
        {
            int num , mult = 1 , suma = 0 , i=1;
            bool supero = false;

            Console.Write("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 10)
            {
                while (i <= 10)
                {
                    mult *= i;
                    i++;
                }
                supero = true;
            }
            else
            {
                while (i <= 10)
                {
                    suma += i;
                    i++;
                }
                supero = false;
            }
            if (supero == true)
                Console.WriteLine("\nLa Mult. es: {0}", mult);
            else
                Console.WriteLine("\nLa suma es: {0}", suma);

            Console.ReadKey();
        }      
    }
}