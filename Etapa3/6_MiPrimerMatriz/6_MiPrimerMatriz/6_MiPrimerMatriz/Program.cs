using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el valor de n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingresar el valor de m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i< n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

            Console.ReadKey();

        }
    }
}
