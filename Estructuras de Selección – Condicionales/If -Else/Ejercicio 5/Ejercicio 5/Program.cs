using System;

namespace Ejercicio_5
{
    class Program
    {
        // 5. Calcular el mayor de dos números leídos del teclado y visualizarlo en pantalla.
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Digite Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("\nNum1: {0} es IGUAL a Num2: {1}", num1, num2);
            else if (num1 > num2)
                Console.WriteLine("\nNum1: {0} es MAYOR a Num2: {1}", num1, num2);
            else
                Console.WriteLine("\nNum1: {0} es MENOR a Num2: {1}", num1, num2);
            Console.ReadKey();
        }
    }
}