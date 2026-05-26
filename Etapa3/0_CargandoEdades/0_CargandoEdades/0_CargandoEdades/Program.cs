using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar del estudiante " + (i + 1) + " : ");
                edades[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("La edad del estudiante" + ( i + 1) + " es: " + edades[i]);
            }

            Console.ReadKey();
        }
    }
}
