using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int n_matriz = n.Next(1, 100);

            Random m = new Random();
            int m_matriz = m.Next(1, 100);

            int[,] matriz = new int[n_matriz , m_matriz];

            for (int i = 0; i < n_matriz; i++)
            {
                for (int j = 0; j < m_matriz; j++)
                {
                    Console.Write(matriz[i, j] + "-");
                }
            }

            Console.ReadKey();
        }
    }
}
