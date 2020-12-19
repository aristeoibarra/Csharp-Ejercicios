using System;

namespace Ejercicio_8
{
    class Program
    {
        /*Hacer un árbol con '*' del tipo: Ejemplo:
            Digite el número de filas: 5
            *
            **
            ***
            ****
            *****
        */
        static void Main(string[] args)
        {
            string caracter = "*";
            int fila;

            Console.Write("Digite el número de filas: ");
            fila = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= fila; i++)
            {
                Console.WriteLine(caracter);
                caracter += "*";
            }
            Console.ReadLine();
        }
    }
}
