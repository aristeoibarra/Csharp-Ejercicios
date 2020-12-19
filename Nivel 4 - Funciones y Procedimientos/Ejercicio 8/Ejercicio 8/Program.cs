using System;

namespace Ejercicio_8
{
    class Program
    {
        // 8. Hacer un programa que muestre 3 números ordenados descendentemente,
        // utilizar un procedimiento para cada operación.
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Digite Num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite Num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Descendente(num1, num2, num3);
            Console.ReadKey();
        }

        private static void Descendente(int num1, int num2, int num3)
        {
            if(num1<= num2 && num1<= num3)
                if(num2<= num3)
                    Console.WriteLine("{0},{1},{2}", num3, num2, num1);
                else
                    Console.WriteLine("{0},{1},{2}", num2, num3, num1);
            
            else if(num2 <= num1 && num2<=num3)
                if(num1<=num3)
                    Console.WriteLine("{0},{1},{2}", num3, num1, num2);
                else
                    Console.WriteLine("{0},{1},{2}", num1, num3, num2);

            else if(num3 <= num1 && num3 <= num2)
                if(num1<= num2)
                    Console.WriteLine("{0},{1},{2}", num2, num1, num3);
                else
                    Console.WriteLine("{0},{1},{2}", num1, num2, num3);

        }
    }
}
