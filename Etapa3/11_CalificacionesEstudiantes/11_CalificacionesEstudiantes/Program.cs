using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalificacionesEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cantidad de Estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            string[,] matriz = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre del Estudiante " + (i+1) + " : ");
                matriz[i, 0] = Console.ReadLine();
                Console.Write("Edad del Estudiante " + (i+1) + " : ");
                matriz[i, 1] = Console.ReadLine();
                Console.Write("Calificación del Estudiante " + (i+1) + " : ");
                matriz[i, 2] = Console.ReadLine();
                Console.Clear();
            }

            for (int h = 0; h < n; h++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(matriz[h, k] + " - ");
                }

                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
