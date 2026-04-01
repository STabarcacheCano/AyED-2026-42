using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Intodusca otro número: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 / num2;
            Console.Write("La division de ambos números da como resultado: "+ resultado);
            Console.ReadKey();
        }
    }
}
