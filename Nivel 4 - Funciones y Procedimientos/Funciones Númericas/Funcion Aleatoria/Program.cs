using System;

namespace Funcion_Aleatoria
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int li, ls;

            Console.Write("Digite el limite inferior: ");
            li = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite el limite superior: ");
            ls = Convert.ToInt32(Console.ReadLine());

            FuncionesAleatorias(li, ls);
            Console.ReadKey();
        }

        private static void FuncionesAleatorias(int li, int ls)
        {
            int numAleatorio;
            numAleatorio = random.Next();
            Console.WriteLine("\nrandom.Next() = {0}", numAleatorio);

            numAleatorio = random.Next(li, ls);
            Console.WriteLine("random.Next({0},{1}) = {2}", li, ls, numAleatorio);

            float num1;
            num1 = (float)random.NextDouble();
            Console.WriteLine("random.NextDouble() = {0}", num1);
        }
    }
}
