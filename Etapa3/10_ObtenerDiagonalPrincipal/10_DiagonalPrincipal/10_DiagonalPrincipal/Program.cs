using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int[] diagonal_principal = new int[5];

            Random valor = new Random();

            for( int i= 0; i<5; i++)
            {
                for (int j =0; j<5; j++)
                {
                    matriz[i,j]= valor.Next(1, 10);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int h = 0; h<5; h++)
            {
                diagonal_principal[h] = matriz[h, h];
            }

            for (int k = 0; k<5; k++)
            {
                Console.Write(diagonal_principal[k] + " ");
            }

            Console.ReadKey();
        }
    }
}
