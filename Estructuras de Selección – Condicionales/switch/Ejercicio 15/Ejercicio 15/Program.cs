using System;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio_15
{
    // 15. Hacer un programa que simule un cajero automático con un saldo inicial de 1000 Dólares.
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            float agregar, retirar, saldoInicial = 1000;

            Console.WriteLine("\tBienvenido a su Cajero Virtual");
            Console.WriteLine("(1)-Ingreso en cuenta");
            Console.WriteLine("(2)-Retirar dinero de la cuenta");
            Console.WriteLine("(3)-Salir");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n¿Cuanto dinero desea ingresar en la cuenta?: ");
                    agregar = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("\nSaldo Anterior: {0}$",saldoInicial);
                    saldoInicial += agregar;
                    Console.WriteLine("El saldo total es de: {0}$", saldoInicial);
                    break;
                case 2:
                    if (saldoInicial > 0)
                    {
                        Console.WriteLine("\n¿Cuanto dinero desea retirar de la cuenta?: ");
                        retirar = Convert.ToSingle(Console.ReadLine());
                        
                        if (retirar > saldoInicial)
                        {
                            Console.WriteLine("\nLa cant. a retirar es mayor al saldo");
                            Console.WriteLine("El saldo total es de: {0}$", saldoInicial);
                        }
                        else
                        {
                            saldoInicial -= retirar;
                            Console.WriteLine("\nRetiro: {0}$", retirar);
                            Console.WriteLine("El saldo total es de: {0}$", saldoInicial);
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("\nSaldo insuficiente");
                    }
                    break;
                case 3: Environment.Exit(0); break;
                default: Console.WriteLine("\nOpción no valida");break;
            }
            Console.ReadKey();
        }
    }
}
