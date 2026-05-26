using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de invitados : ");
            int cantidad_invitados = int.Parse(Console.ReadLine());
            int[] invitados = new int[cantidad_invitados];

            int total_porciones = 0;

            for (int i = 0; i < cantidad_invitados; i++)
            {
                int porción = 0;
                while (porción < 1 || porción > 100)
                {
                    Console.WriteLine("Ingresar cantidad de comida del invitado " + ( i + 1) + " : ");
                    porción = int.Parse(Console.ReadLine());
                }
                total_porciones += porción;
            }

            Console.WriteLine("El Promedio de comida por invitado es: " + (total_porciones / cantidad_invitados));

            Console.ReadKey();
        }
    }
}
