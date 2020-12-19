using System;

namespace Ejercicio_5
{
    class Program
    {
        //5. Hacer un Programa que calcule áreas de trapecios.
        static void Main(string[] args)
        {
            float baseMayor,baseMenor,altura,area;

            Console.Write("Digite la Base Mayor: ");
            baseMayor = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite la Base Menor: ");
            baseMenor = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite la Altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            // A = ((B + b)/2) * h
            area = ((baseMayor + baseMenor) / 2) * altura;

            Console.WriteLine("\nEl area es: {0}",area);
            Console.ReadKey();
        }
    }
}
