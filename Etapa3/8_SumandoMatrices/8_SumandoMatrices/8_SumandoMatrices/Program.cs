using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Random valor = new Random();

            int[,] matriz_1 = new int[n, n];
            int[,] matriz_2 = new int[n, n];

            int[,] matriz_suma = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for ( int j= 0; j < n; j++)
                {
                    
                    int a = valor.Next(1, 10);
                    matriz_1[i, j] = a;
                    Console.Write(matriz_1[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int a = valor.Next(1, 10);
                    matriz_2[i, j] = a;
                    Console.Write(matriz_2[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_suma[i, j] = matriz_1[i, j] + matriz_2[i, j];
                    Console.Write(matriz_suma[i, j] + "-");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();

        }
    }
}
