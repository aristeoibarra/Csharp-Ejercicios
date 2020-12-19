using System;

namespace Ejercicio_14
{
    class Program
    {
        // 14. Mostrar los meses del año, pidiéndole al usuario un número entre (1-12), y mostrar
        // y mostrar el mes al que corresponde.
        static void Main(string[] args)
        {
            int numMes;
            string texto = "\nEl mes es: ";

            Console.WriteLine("Mes del año");
            Console.Write("Digite un numero entre (1-12): ");
            numMes = Convert.ToInt32(Console.ReadLine());

            switch (numMes)
            {
                case 1: Console.WriteLine($"{texto}Enero"); break;
                case 2: Console.WriteLine($"{texto}Febrero"); break;
                case 3: Console.WriteLine($"{texto}Marzo"); break;
                case 4: Console.WriteLine($"{texto}Abril"); break;
                case 5: Console.WriteLine($"{texto}Mayo"); break;
                case 6: Console.WriteLine($"{texto}Junio"); break;
                case 7: Console.WriteLine($"{texto}Julio"); break;
                case 8: Console.WriteLine($"{texto}Agosto"); break;
                case 9: Console.WriteLine($"{texto}Septiembre"); break;
                case 10: Console.WriteLine($"{texto}Octubre"); break;
                case 11: Console.WriteLine($"{texto}Noviembre"); break;
                case 12: Console.WriteLine($"{texto}Diciembre"); break;
                default: Console.WriteLine("\nNumero no valido"); break;
            }
            Console.ReadKey();
        }
    }
}
