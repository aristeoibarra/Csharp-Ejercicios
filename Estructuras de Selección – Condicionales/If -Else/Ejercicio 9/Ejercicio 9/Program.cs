using System;

namespace Ejercicio_9
{
    class Program
    {
        // 9. Hacer un Programa que borre la pantalla al pulsar 1.
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("HOLA A TODOS");
            Console.WriteLine("/**58825565655/");
            Console.WriteLine("558sdsaafsfafasfsafafasfas");
            Console.WriteLine("/**58825565655/");
            Console.WriteLine("558sdsaafsfafasfsafafasfas");
            Console.WriteLine("/**58825565655/");
            Console.WriteLine("558sdsaafsfafasfsafafasfas");
            Console.WriteLine("/**58825565655/");
            Console.WriteLine("558sdsaafsfafasfsafafasfas");

            Console.WriteLine("\n¿Desea borrar pantalla?");
            Console.Write("(1)Si : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                Console.Clear();
            Console.ReadKey();
        }
    }
}
