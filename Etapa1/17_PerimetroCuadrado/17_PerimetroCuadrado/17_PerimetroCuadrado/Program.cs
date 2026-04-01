using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar una longitud de un cuadrado: ");
            int longitud = int.Parse(Console.ReadLine());
            int perimetro = longitud * 4;
            double area = Math.Pow(longitud, 2);
            Console.Write("El perimetro del cuadrado es " + perimetro + " y su area es " + area);
            Console.ReadKey();

            
        }
    }
}
