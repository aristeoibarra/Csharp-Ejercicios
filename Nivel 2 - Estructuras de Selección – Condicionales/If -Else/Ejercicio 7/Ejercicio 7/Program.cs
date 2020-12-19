using System;

namespace Ejercicio_7
{
    class Program
    {
        // 7. Ingresar por teclado el nombre y el signo de cualquier persona e imprima,
        // el nombre solo si la persona es signo Aries, caso contrario imprima no es signo Aries.
        static void Main(string[] args)
        {
            string nombre, signo;

            Console.Write("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su signo zodiacal: ");
            signo = Console.ReadLine();

            if (signo == "aries" || signo == "Aries")
                Console.WriteLine("\nSu nombre es: {0}",nombre);
            else
                Console.WriteLine("\nNo es signo Aries");
            Console.ReadKey();
        }
    }
}
