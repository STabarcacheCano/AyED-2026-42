using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buen día, como estas");

            Console.WriteLine("¿Cómo es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿Cómo es tu apellido?");
            string apellido = Console.ReadLine();

            Console.WriteLine("Como es tu DNI");
            string DNI = Console.ReadLine();

            Console.WriteLine("ingrese su edad");
            string edad = Console.ReadLine();

            Console.WriteLine(("Saludos, " + nombre + " " + apellido + "de DNI" + DNI + "y de edad" + edad);

            Console.ReadKey();
        }
    }
}