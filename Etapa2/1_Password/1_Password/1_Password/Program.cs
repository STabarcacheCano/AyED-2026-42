using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            const string contraseña = "Hola" ;
            Console.Write("Ingrese la contraseña: ");
            string comprobación = Console.ReadLine();
            
            if (contraseña == comprobación)
            {
                Console.Write("La contraseña coincide con la contraseña.");
            }
            else
            {
                Console.Write("No coincide.");
            }
            Console.ReadKey();
        }
    }
}
