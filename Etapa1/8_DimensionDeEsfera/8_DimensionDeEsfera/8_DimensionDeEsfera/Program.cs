using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca un radio: ");
            float radio = float.Parse(Console.ReadLine());
            float r_2 = radio * radio;
            double superficie = 4 * 3.14 * r_2;
            float r_3 = radio * radio * radio; 
            double volumen = 4 * 3.14 / 3 * r_3;
            Console.WriteLine("La superficie de la esfera es: " + superficie);
            Console.Write("El volumen de la esfera es: " + volumen);
            Console.ReadKey();
            






        }
    }
}
