using System;

namespace Ejercicio_6
{
    //6. Hacer un programa que muestre una tabla de multiplicar hasta el 20
    // de un número cualquiera por pantalla, 
    // el número se pedirá en el programa principal. Usar procedimiento.
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("\tTabla de Multiplicar");
            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            MostrarTabla(numero);
            Console.ReadKey();
        }

        private static void MostrarTabla(int numero)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",numero,i,(numero * i));
            }
        }
    }
}
