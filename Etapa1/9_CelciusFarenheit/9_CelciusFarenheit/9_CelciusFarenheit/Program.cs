using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un grado centigrado celcius: ");
            float grado = float.Parse(Console.ReadLine());
            float a = 9 / 5;
            float farenheit = grado * a + 32;
            double kelvin = grado + 273.15;
            Console.WriteLine("En grados farenheit son: " + farenheit);
            Console.Write("En grados Kelvin: " + kelvin);
            Console.ReadKey();
        }
    }
}
