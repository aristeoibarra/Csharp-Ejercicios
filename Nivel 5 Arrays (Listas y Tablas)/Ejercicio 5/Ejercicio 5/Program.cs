using System;

namespace Ejercicio_5
{
    /*5. Realice un programa que lea en un array el sexo de los N estudiantes
     * del curso de Algoritmos y que determine cuantos hombres y cuantas mujeres
     * se encuentran en el grupo, suponiendo que los datos son extraídos alumno por alumno.*/
    class Program
    {
        static void Main(string[] args)
        {
            int numero, hombre=0, mujer=0;
            string[] SexoAlumnos;

            Console.Write("Digite el total de alumno de la clase: ");
            numero = Convert.ToInt32(Console.ReadLine());
            SexoAlumnos = new string[numero];

            Console.WriteLine();
            for (int i = 0; i < numero; i++)
            {
                Console.Write(" {0}. Digite el sexo del alumn@: ",(i+1));
                SexoAlumnos[i] = Console.ReadLine();

                if (SexoAlumnos[i].Contains("Masculino") == true)
                    hombre++;
                else if (SexoAlumnos[i].Contains("Femenino") == true)
                    mujer++;
            }

            Console.WriteLine("\n El total de hombres es: {0}",hombre);
            Console.WriteLine(" El total de mujeres es: {0}", mujer);
            Console.ReadKey();
        }
    }
}
