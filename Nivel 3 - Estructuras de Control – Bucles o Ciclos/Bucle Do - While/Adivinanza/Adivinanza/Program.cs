using System;

namespace Adivinanza
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Seleccionando un número al azar...");
            int num,numSecreto = random.Next(1, 50);

            Console.WriteLine(numSecreto);
            int intentos = 0;
            do
            {               
                Console.WriteLine("Intento[{0}]!",(intentos+1));
                Console.Write("Adivina el numero secreto: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num == numSecreto)
                {
                    Console.WriteLine("Felicidades, ¡Ganaste!");
                    break;
                }
                else if (num > numSecreto)
                {
                    Console.WriteLine("El número secreto es más pequeño");
                }
                else
                {
                    Console.WriteLine("El número secreto es mayor");
                }
                Console.WriteLine();
                intentos++;
            } while (intentos!=5);

            Console.WriteLine("\nEl número secreto es: {0}",numSecreto);
            Console.ReadKey();
        }
    }
}
