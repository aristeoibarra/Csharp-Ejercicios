using System;

namespace Operador_Interrogacion
{
    /* Expresión condicional: El operador '?'
     Sintaxis:
           var valor = ( condición ) ? verdadero : falso
                       Condición ? Expresión1 : Expresión2;  
    */
    // Numero par
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            string resultado = (numero % 2 == 0) ? "\nEl numero es: PAR" : "\nEl numero es: IMPAR";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
