using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Responder con si o no: ");
            Console.Write("Tiene comida: ");
            string comida = Console.ReadLine();
            Console.Write("Tiene Refugio: ");
            string refugio = Console.ReadLine();
            Console.Write("Tenes un bate: ");
            string bate = Console.ReadLine();
            Console.Write("Tenes agua: ");
            string agua = Console.ReadLine();

            bool comida_2 = (comida == "si" || comida == "Si");
            bool agua_2 = (agua == "si" || agua == "Si");
            bool refugio_2 = (refugio == "si" || refugio == "Si");
            bool bate_2 = (bate == "si" || bate == "Si");



            if ((comida_2 == true && agua_2 == true && refugio_2 == true && bate_2 == true) || (comida_2 == false && agua_2 == true && refugio_2 == true && bate_2 == true) || (agua_2 == true && bate_2 == true) || (bate_2 == true && comida_2 == true) || (comida_2 == true && agua_2 == true))
            {
                Console.Write("Sobrevive.");
            }
            else
            {
                Console.Write("No sobrevive.");
            }

            Console.ReadKey();

        }
    }
}
