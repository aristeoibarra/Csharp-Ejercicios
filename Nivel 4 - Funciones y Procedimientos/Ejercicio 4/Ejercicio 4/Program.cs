using System;

namespace Ejercicio_4
{
    class Program
    {
        /*4. Hacer un programa que pida por pantalla un número del 1 al 10 
         * y mediante un procedimiento muestre por pantalla el número escrito en letras.*/
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite un numero de 1-10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            NumeroToLetra(numero);
            Console.ReadKey();
        }

        private static void NumeroToLetra(int numero)
        {
            switch (numero)
            {
                case 1: Console.WriteLine("\nUno");break;
                case 2: Console.WriteLine("\nDos"); break;
                case 3: Console.WriteLine("\nTres"); break;
                case 4: Console.WriteLine("\nCuatro"); break;
                case 5: Console.WriteLine("\nCinco"); break;
                case 6: Console.WriteLine("\nSeis"); break;
                case 7: Console.WriteLine("\nSiete"); break;
                case 8: Console.WriteLine("\nOcho"); break;
                case 9: Console.WriteLine("\nNueve"); break;
                case 10: Console.WriteLine("\nDiez"); break;
                default: Console.WriteLine("\nNumero no valido"); break;
            }
        }
    }
}
