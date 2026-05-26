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
            int[] participantes = new int[int.Parse(Console.ReadLine())];

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
                Console.Write(punto + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("El puntaje mayor fue: " + participantes[participantes.Length]);
            Console.WriteLine("El puntaje menor fue: " + participantes[0]);

            Console.ReadKey();
        }
    }
}
