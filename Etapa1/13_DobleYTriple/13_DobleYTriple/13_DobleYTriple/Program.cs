using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un número: ");
            int numero = int.Parse(Console.ReadLine());
            int doble = numero * 2;
            int triple = numero * 3;
            Console.WriteLine("El doble del número es: " + doble);
            Console.Write("El triple del número es: " + triple);
            Console.ReadKey();
        }
    }
}
