using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el valor de un lado del triangulo: ");
            int lado_1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar el valor del segundo lado: ");
            int lado_2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar el valor del tercer lado: ");
            int lado_3 = int.Parse(Console.ReadLine());

            if ((lado_1 == lado_2) && (lado_2 == lado_3) && (lado_1 == lado_3))
            {
                Console.Write("El triengulo es equilatero.");
            }
            else
            {
                if ((lado_1 != lado_2) && (lado_2 != lado_3) && (lado_1 != lado_3))
                {
                    Console.Write("El triangulo es escaleno.");
                }
                else
                {
                    Console.Write("El triangulo es isosceles");
                }
            }

            Console.ReadKey();
        }
    }
}
