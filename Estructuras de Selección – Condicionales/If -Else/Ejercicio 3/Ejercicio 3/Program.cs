using System;

namespace Ejercicio_3
{
    class Program
    {
        // 3. Visualizar la tarifa de la luz según el gasto de corriente eléctrica.
        // Para un gasto menor de 1000Kwxh la tarifa es 1.2,
        // entre 1000 y 1850Kwxh es 1.0 y mayor de 185OKwxh 0.9.
        static void Main(string[] args)
        {
            int gastoCorriente;

            Console.Write("Digite el gasto de corriente: ");
            gastoCorriente = Convert.ToInt32(Console.ReadLine());

            if (gastoCorriente < 1000)
                Console.WriteLine("\nLa tarifa es de 1.2"); 
            else if (gastoCorriente >= 1000 && gastoCorriente < 1850)
                Console.WriteLine("\nLa tarifa es de 1.0");
            else if (gastoCorriente >= 1850)
                Console.WriteLine("\nLa tarifa es de 0.9");

            Console.ReadKey();
        }
    }
}
