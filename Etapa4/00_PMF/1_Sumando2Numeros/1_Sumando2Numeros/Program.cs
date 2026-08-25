using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el primer número a sumar: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ingresar el segundo número a sumar: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLa suma de ambos números da: " + Sumar(b, a));

            Console.ReadKey();
        }
        static int Sumar(int n, int nn)
        {
            int resultado = n + nn;
            return resultado;
        }
    }
}
