using System;


namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {           
            Random random = new Random();
            int numAleatorio = random.Next(0, 100);
            int numero, intentos = 0;

            Console.WriteLine("Adivina el numero aleatorio");
            do
            {
                intentos++;
                Console.Write("I[{0}]: Digite un numero: ", intentos);
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > numAleatorio) Console.WriteLine("El numero aleatorio es más pequeño");
                else if (numero < numAleatorio) Console.WriteLine("El numero aleatorio es mayor");

            } while (numAleatorio != numero);

            Console.WriteLine("\nFelicidades, ¡Ganaste!");
            Console.WriteLine("El numero aleatorio es: {0}", numAleatorio);
            Console.WriteLine("Numero de intentos: {0}",intentos);
            Console.ReadKey();
        }
    }
}
