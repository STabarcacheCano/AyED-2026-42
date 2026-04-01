using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MiMultiplicación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introdusca otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 * num2;
            Console.Write("La múltiplicación de ambos números da como resultado: " + resultado);
            Console.ReadKey();
        }
    }
}
