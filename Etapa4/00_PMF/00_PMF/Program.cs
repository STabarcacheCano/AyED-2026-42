using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PMF
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5, c = 2;
            Saludar("Sasha");
            Console.WriteLine(Sumar(b, a));
            Console.WriteLine(Sumar(a, c));
            Console.WriteLine(Sumar(Sumar(b, a), Sumar(a, c)));
            Console.ReadKey();
        }
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        static int SumarDos(int n)
        {
            int resultado = n + 2;
            return resultado;
        }
        static int Sumar(int n, int nn)
        {
            int resultado = n + nn;
            return resultado;

        }
    }
}
