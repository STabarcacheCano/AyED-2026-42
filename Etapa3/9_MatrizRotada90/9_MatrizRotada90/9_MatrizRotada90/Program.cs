using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Random valor = new Random();

            int[,] matriz = new int[n, n];
            int[,] matriz90 = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    int a = valor.Next(1, 10);
                    matriz[i, j] = a;
                    Console.Write(matriz[i, j] + "-");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    matriz90[j, (n - 1 - i)] = matriz[i, j];
                }

            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz90[i, j] + "-");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
