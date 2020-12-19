using System;

namespace Ejercicio_6
{
    class Program
    {
        // 6. Ingrese un número y calcule e imprima su raíz cuadrada.
        // Si el número es negativo imprima el número y un mensaje que diga “tiene raíz imaginaria”.
        static void Main(string[] args)
        {
            float num,raizCuadrada;

            Console.Write("Ingrese un número: ");
            num = Convert.ToSingle(Console.ReadLine());

            raizCuadrada = (float)Math.Sqrt(num);

            if(raizCuadrada >= 0)
                Console.WriteLine("\nLa raiz cuadrada de {0} es: {1}",num,raizCuadrada);
            else
                Console.WriteLine("\nTiene raíz imaginaria");
           
            Console.ReadKey();
        }
    }
}