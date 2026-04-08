using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDeNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de monedas doradas: ");
            int doradas = int.Parse(Console.ReadLine());
            Console.Write("Ingresar cantidad de monedas plateadas: ");
            int plateadas = int.Parse(Console.ReadLine());

            int suma = (doradas * 10) + (plateadas * 2);

            if (suma < 50)
            {
                Console.Write("Nivel Insuficiente:");
            }
            else
            {
                if (suma <= 99)
                {
                    Console.Write("Nivel Superado");
                }
                else
                {
                    Console.Write("Nivel Completado");
                }
            }

            Console.ReadKey();

        }
    }
}
