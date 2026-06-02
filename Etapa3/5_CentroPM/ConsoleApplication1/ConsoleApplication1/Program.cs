

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] nombres = new string[5];

            Console.WriteLine(" 5 NOMBRES ");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Introduce el nombre número {i + 1}: ");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine(" MOSTRANDO LOS NOMBRES ");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre en la posición {i}: {nombres[i]}");
            }


            Console.ReadLine();
        }
    }
}
