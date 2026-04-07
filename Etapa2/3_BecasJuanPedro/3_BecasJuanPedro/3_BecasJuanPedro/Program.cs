using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Cual es su ingreso?: ");
            int ingresos = int.Parse(Console.ReadLine());
            
            if ((edad > 19 && ingresos <= 100000) || (edad < 19 && ingresos == 0) || (edad == 19 && ingresos <= 50000))
            {
                Console.Write("Puede cobrar la beca.");
            }
            else
            {
                Console.Write("No puede cobrar la beca.");
            }

            Console.ReadKey();
        
        }
    }
}
