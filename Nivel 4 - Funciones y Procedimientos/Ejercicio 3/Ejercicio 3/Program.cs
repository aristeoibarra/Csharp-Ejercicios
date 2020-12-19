using System;
using System.ComponentModel.Design;

namespace Ejercicio_3
{
    class Program
    {
        /*3. Hacer un programa que muestre un menú con las opciones
         * sumar, restar, multiplicar y dividir, el programa solicitará
         * una opción y realizará la tarea elegida, se debe usar procedimientos.*/
       static float num1, num2;
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n\tMenu");
                Console.WriteLine("(1) - Sumar");
                Console.WriteLine("(2) - Restar");
                Console.WriteLine("(3) - Multiplicar");
                Console.WriteLine("(4) - Dividir");
                Console.WriteLine("(5) - Salir");
                Console.Write("Opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Console.Clear(); Sumar();  break;
                    case 2: Console.Clear(); Restar(); break;
                    case 3: Console.Clear(); Multiplicar(); break;
                    case 4: Console.Clear(); Dividir(); break;
                }
            } while (opcion != 5);
        }

        private static void Dividir()
        {
            DatosUsuarios();
            if(num2 !=0)
                Console.WriteLine("\nLa divicion es: {0}", (num1 / num2));
            else
                Console.WriteLine("\nOperacion no valida");
        }

        private static void Multiplicar()
        {
            DatosUsuarios();
            Console.WriteLine("\nLa multiplicacion es: {0}", (num1 * num2));
        }

        private static void Restar()
        {
            DatosUsuarios();
            Console.WriteLine("\nLa resta es: {0}", (num1 - num2));   
        }

        private static void Sumar()
        {
            DatosUsuarios();
            Console.WriteLine("\nLa suma es: {0}",(num1+num2));
        }
        static void DatosUsuarios()
        {
            Console.Write("\nDigite num1: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite num2: ");
            num2 = Convert.ToSingle(Console.ReadLine());
        }
    }
}
