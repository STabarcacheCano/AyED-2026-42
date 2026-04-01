using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar un número: ");
            int numero = int.Parse(Console.ReadLine());
            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado del número es: "+ cuadrado);
            Console.Write("El cubo del número es: "+ cubo);
            Console.ReadKey();
        }
    }
}
