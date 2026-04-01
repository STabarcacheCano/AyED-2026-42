using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de minutos: ");
            int min = int.Parse(Console.ReadLine());
            int horas = min / 60;
            float minutos = min % 60;
            Console.Write("Esos minutos son: " + horas + "h y " + minutos + "min.");
            Console.ReadKey();
        }
    }
}
