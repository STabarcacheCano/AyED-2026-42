using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MiResto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Introdusca otro número: ");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = num1 % num2;
            Console.Write("El resto de la division de ambos numeros son: " + resultado);
            Console.ReadKey();
        }
    }
}
