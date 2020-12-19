using System;

namespace Ejercicio_3
{
    /* 3. Hacer 2 arrays de cadena de caracteres, 
     *  pedir el nombre al usuario guardarlo dentro de un array y luego,
     *  copiar el contenido de ese array a otro.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayName = new string[3];
            string[] arrayCopyName = new string[3];

            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.Write("Digite Nombre ({0}): ", (i+1));
                arrayName[i] = Console.ReadLine();
            }

            arrayName.CopyTo(arrayCopyName, 0);

            for (int i = 0; i < arrayCopyName.Length; i++)
            {
                Console.WriteLine(arrayCopyName[i]);
            }
            Console.ReadKey();
        }
    }
}
