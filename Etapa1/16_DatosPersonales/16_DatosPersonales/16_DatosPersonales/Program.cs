using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            Console.Write("Ingrese el nombre de la ciudad donde vive: ");
            string ciudad = Console.ReadLine();
            Console.Write("Su nombre es " + nombre + " su edad es " + edad + " y vive en la ciudad " + ciudad);
            Console.ReadKey();
        }
    }
}
