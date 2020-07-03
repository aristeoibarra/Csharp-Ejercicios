using System;

namespace Ejercicio_9
{
    class Program
    {
        // 9. Determinar si un Número es Primo o no.
        static void Main(string[] args)
        {
            int num, cont =0;

            Console.Write("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num != 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        cont++;
                }

                if (cont > 2)
                    Console.WriteLine("\nEl numero es COMPUESTO");
                else
                    Console.WriteLine("\nEl numero es PRIMO");
            }
            else
            {
                Console.WriteLine("\nEl número 1, no es PRIMO ni COMPUESTO");
            }
            
            Console.ReadKey();
        }
    }
}
