using System;

namespace Ejercicio_9
{
    class Program
    {
        // Calcular el nuevo salario de un obrero, si obtuvo un incremento del 25% sobre su salario anterior.
        static void Main(string[] args)
        {
            float incremento, salarioAnterior, salarioNuevo;
            
            Console.Write("Digite salario actual: ");
            salarioAnterior = Convert.ToSingle(Console.ReadLine());

            incremento = salarioAnterior * (25.0f / 100.0f);
            salarioNuevo = salarioAnterior + incremento;

            Console.WriteLine("\nIncremento 25%: {0}$",incremento);
            Console.WriteLine("Nuevo Salario: {0}$",salarioNuevo);
            Console.ReadKey();
        }
    }
}
