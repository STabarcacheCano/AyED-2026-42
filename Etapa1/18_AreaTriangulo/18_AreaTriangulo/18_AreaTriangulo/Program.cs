using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la base de un triangulo: ");
            int base_t = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la altura de un triangulo: ");
            int altura = int.Parse(Console.ReadLine());
            float multiplicación = base_t * altura;
            float area = multiplicación / 2;
            Console.Write("El area del triangulo es: " + area);
            Console.ReadKey();
        }
    }
}
