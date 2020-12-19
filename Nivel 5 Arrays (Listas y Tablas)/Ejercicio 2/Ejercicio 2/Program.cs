using System;
using System.Runtime.InteropServices;

namespace Ejercicio_2
{
    class Program
    {
        /*2. Crear un programa que tenga un array de 100 números aleatorios entre 1 y 1000.
         * Una vez creado organizarlo de tal manera que almacene los números pares en un array
         * y los impares en otro.*/
        static void Main(string[] args)
        {
            int[] numero = new int[100];
            int contPares = 0, contImpares = 0;
            int[] numPar, numImpar;

            NumerosAleatorios(numero);

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] % 2 == 0)
                    contPares++;
                else
                    contImpares++;
            }
            numPar = new int[contPares];
            numImpar = new int[contImpares];

            OrdenarNumeros(numero, numPar, numImpar);

            Console.WriteLine("Array 'numero': {0}", numero.Length);
            ImprimirArray(numero);
            Console.WriteLine("\n\nArray 'numPar': {0}", numPar.Length);
            ImprimirArray(numPar);
            Console.WriteLine("\n\nArray 'numImpar': {0}", numImpar.Length);
            ImprimirArray(numImpar);
            Console.ReadKey();
        }

        private static void NumerosAleatorios(int[] numero)
        {
            Random random = new Random();
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = random.Next(1, 1000);
            }
        }

        static void OrdenarNumeros(int[] numero, int[] numPar, int[] numImpar)
        {
            int indexPar = 0, indexImpar = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] % 2 == 0)
                {
                    numPar[indexPar] = numero[i];
                    indexPar++;
                }
                else
                {
                    numImpar[indexImpar] = numero[i];
                    indexImpar++;
                }
            }
        }

        static void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ,", array[i]);
            }
        }
    }
}
