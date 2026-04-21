using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnioBisiestro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un año: ");
            int año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0) && (año % 100 != 0))
            {
                Console.Write("Es un año bisiesto.");
            }
            else
            {
                if (año % 400 == 0)
                {
                    Console.Write("Es un año bisiesto.");
                }
                else
                {
                    Console.Write("No es un año bisiesto.");
                }
            }

            Console.ReadKey();
        }
    }
}
