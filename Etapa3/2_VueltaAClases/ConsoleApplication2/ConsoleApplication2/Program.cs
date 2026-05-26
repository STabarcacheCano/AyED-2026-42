using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] tablas;

            tablas = new string[8][];

            tablas[0] = new string[6];
            tablas[1] = new string[6];
            tablas[2] = new string[6];
            tablas[3] = new string[6];
            tablas[4] = new string[6];
            tablas[5] = new string[6];
            tablas[6] = new string[6];
            tablas[7] = new string[6];

            Console.WriteLine("tabla 0");

            for (int i = 0; i < tablas[0].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[0][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 1");

            for (int i = 0; i < tablas[1].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[1][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 2");

            for (int i = 0; i < tablas[0].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[0][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 3");

            for (int i = 0; i < tablas[1].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
               tablas[1][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 4");

            for (int i = 0; i < tablas[0].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
               tablas[0][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 5");

            for (int i = 0; i < tablas[1].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[1][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 6");

            for (int i = 0; i < tablas[0].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[0][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("tabla 7");

            for (int i = 0; i < tablas[1].Length; i++)
            {
                Console.Write("Ingrese una palabra: ");
                tablas[1][i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Palabras guardadas:");

            for (int i = 0; i < tablas.Length; i++)
            {
                Console.WriteLine("Grupo " + (i + 1));

                for (int j = 0; j < tablas[i].Length; j++)
                {
                    Console.WriteLine(tablas[i][j]);
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
