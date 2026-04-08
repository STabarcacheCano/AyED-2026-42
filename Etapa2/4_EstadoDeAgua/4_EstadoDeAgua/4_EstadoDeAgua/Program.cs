using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la temperatura del agua en grados Celsius: ");
            int grados = int.Parse(Console.ReadLine());

            if (grados <= 0)
            {
                Console.Write("Se congela el agua.");
            }
            else
            {
                if (grados >= 100)
                {
                    Console.Write("El agua hierve.");
                }
                else
                {
                    Console.Write("El agua esta en estado liquida.");
                }
            }
            Console.ReadKey();
        }
    }
}
