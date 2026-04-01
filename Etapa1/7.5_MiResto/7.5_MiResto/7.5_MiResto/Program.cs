using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introdusca otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = num1 / num2;
            int resto = num1 % num2;
            Console.WriteLine("El resultado de la division de ambos números es: " + resultado);
            Console.Write("Y su resto es: " + resto);
            Console.ReadKey();
        }
    }
}
