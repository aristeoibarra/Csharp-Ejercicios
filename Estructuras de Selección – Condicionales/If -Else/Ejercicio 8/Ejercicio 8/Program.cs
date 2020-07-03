using System;

namespace Ejercicio_8
{
    class Program
    {
        // 8. Ingresar por teclado el nombre, la edad y el sexo de cualquier persona e imprima,
        // solo si la persona es de sexo masculino y mayor de edad, el nombre de la persona.
        static void Main(string[] args)
        {
            string nombre, sexo;
            int edad;

            Console.Write("Ingrese su Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese su Sexo: ");
            sexo = Console.ReadLine();

            if ((sexo == "Masculino" || sexo == "masculino") && edad >= 18)
                Console.WriteLine("\nSu nombre es: {0}",nombre);
            else
                Console.WriteLine("\nNo cumple los requisitos");
            Console.ReadKey();
        }
    }
}
