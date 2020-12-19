using System;

namespace Ejercicio_10
{
    class Program
    {
       // 10. Una distribuidora de motocicletas tiene una promoción de fin de año que consiste en lo siguiente.
       // Las motos marca Honda tienen un descuento del 5%, las marcas Yamaha del 8% y las Suzuki del 10%, las otras marcas 2%.
        static void Main(string[] args)
        {
            const int HONDA = 5;
            const int YAMAHA = 8;
            const int OTRASMARCAS = 2;
            int num;

            Console.WriteLine("(1) Honda");
            Console.WriteLine("(2) Yamaha");
            Console.WriteLine("(3) Otras Marcas");
            Console.Write("Ver promoción de: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("\nHONDA tiene un descuento del {0}%", HONDA); break;
                case 2: Console.WriteLine("\nYAMAHA tiene un descuento del {0}%", YAMAHA); break;
                case 3: Console.WriteLine("\nOTRAS MARCAS tienen un descuento del {0}%", OTRASMARCAS); break;
                default: Console.WriteLine("\nNo hay en existencia"); break;
            }
            Console.ReadKey();
        }
    }
}
