using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_NombreCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Su nombre es " + nombre + " y tu apellido es " + apellido );
            Console.ReadKey();
        }
    }
}
