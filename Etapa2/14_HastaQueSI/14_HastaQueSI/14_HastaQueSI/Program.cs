using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Desea terminar el programa?: ");
            string respuesta = Console.ReadLine();

            while (respuesta != "SI")
            {
                Console.Write("Desea terminar el programa?: ");
                respuesta = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
