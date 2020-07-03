using System;

namespace Ejercicio_8
{
    class Program
    {
        //Dadas las horas trabajadas de una persona y el valor por hora.Calcular su salario e imprimirlo.
        static void Main(string[] args)
        {
            float hrsTrabajadas, valorXHora,salario;

            Console.Write("Digite horas trabajadas: ");
            hrsTrabajadas = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite el valor por hora trabajada: ");
            valorXHora = Convert.ToSingle(Console.ReadLine());

            salario = hrsTrabajadas * valorXHora;

            Console.WriteLine("\nSu salario es: {0}$",salario);
            Console.ReadKey();
        }
    }
}
