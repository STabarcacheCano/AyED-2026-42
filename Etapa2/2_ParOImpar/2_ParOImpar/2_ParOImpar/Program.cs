using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.Write("El número es par.");
            }
            else
            {
                Console.Write("El número es impar.");
            }
            Console.ReadKey();
        }
    }
}
