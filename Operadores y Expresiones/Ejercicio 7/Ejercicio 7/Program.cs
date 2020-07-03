using System;

namespace Ejercicio_7
{
    class Program
    {
        // 7. Una tienda ofrece un descuento del 15% sobre el total de la compra
        //    y un cliente desea saber cuánto deberá pagar finalmente por su compra.
        static void Main(string[] args)
        {
            float compra,descuento=0, compraDescuento;

            Console.Write("Digite el total de la compra: ");
            compra = Convert.ToSingle(Console.ReadLine());

            // D = (descuento% / 100) * compra
            descuento = (15.0f/100.0f)* compra;
            compraDescuento = compra - descuento;

            Console.WriteLine("\nDescuento 15%: {0}$",descuento);
            Console.WriteLine("Total con descuento: {0}$", compraDescuento);
            Console.ReadKey();
        }
    }
}
