using System;

namespace Ejercicio_16
{
    class Program
    {
        /*16. Hace un menú que considere las siguientes opciones:
                Caso 1: Cubo de un numero
                Caso 2: Numero par o impar
                Case 3: salir.
        */
        static int num, opcion;
        static void Main(string[] args)
        {
            Console.WriteLine("\tMenú");
            Console.WriteLine("(1) - Cubo de un numero");
            Console.WriteLine("(2) - Numero par o impar");
            Console.WriteLine("(3) - Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    PedirNumero();
                    Console.WriteLine("\nNumero {0}^3 es: {1}",num,(Math.Pow(num,3)));
                    break;
                case 2:
                    PedirNumero();
                    if (num == 0)
                        Console.WriteLine("\nES CERO");
                    else if((num % 2) == 0)
                        Console.WriteLine("\nEl numero {0} es: PAR",num);
                    else
                        Console.WriteLine("\nEl numero {0} es: IMPAR", num);
                    break;
                case 3: Environment.Exit(0);break;
                default:
                    Console.WriteLine("\nOpción no valida");
                    break;
            }
            Console.ReadKey();
        }
        static void PedirNumero()
        {
            Console.Write("\nDigite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
    }
}
