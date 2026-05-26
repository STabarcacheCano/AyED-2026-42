using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de participantes : ");
            int cantidad_participantes = int.Parse(Console.ReadLine());
            int[] participantes = new int[cantidad_participantes];

            for (int i = 0; i < participantes.Length; i++)
            {
                Console.Write("Ingresar puntaje del jugador " + (i + 1)+ " : ");
                participantes[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(participantes);

            Console.Clear();
            Console.Write("La lista de los puntos ordenados son: ");
            foreach (int punto in participantes)
            {
                Console.Write(punto + " ");
            }
            Console.WriteLine("");
            int puntaje_bajo = participantes[0];
            int puntaje_mayor = participantes[0];

            for (int i = 1; i < participantes.Length; i++)
            {
                if (participantes[i] > puntaje_mayor)
                {
                    puntaje_mayor = participantes[i];
                }
                if (participantes[i] < puntaje_bajo)
                {
                    puntaje_bajo = participantes[i];
                }
            }
            Console.WriteLine("El puntaje más alto es: " + puntaje_mayor);
            Console.WriteLine("El puntaje más bajo es: " + puntaje_bajo);
            Console.ReadKey();
        }
    }
}
