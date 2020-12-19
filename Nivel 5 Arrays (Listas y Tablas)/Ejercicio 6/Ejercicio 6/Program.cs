using System;
using System.Linq;

namespace Ejercicio_6
{
    class Program
    {
       /* 6. Realice un programa que permita leer una cadena de caracteres y 
        * que devuelva el número de caracteres que tiene dicha cadena
        * e imprimir dicha cadena al revés.*/
        static void Main(string[] args)
        {
            char[] caracteres = new char[] {'a','e','i','o','u'};

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write("{0} ", caracteres[i]);
            }

            Array.Reverse(caracteres);
            Console.WriteLine();
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write("{0} ", caracteres[i]);
            }
            Console.ReadKey();
        }
    }
}
