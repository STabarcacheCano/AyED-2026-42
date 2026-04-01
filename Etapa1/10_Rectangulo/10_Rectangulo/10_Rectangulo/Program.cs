using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdusca el ancho de un rectangulo: ");
            float ancho = float.Parse(Console.ReadLine());
            Console.Write("Introdusca el alto de un rectangulo: ");
            float alto = float.Parse(Console.ReadLine());
            float perimetro = alto * 2 + ancho * 2;
            float area = alto * ancho;
            float a = ancho * ancho + alto * alto;
            double diagonal = Math.Sqrt(a);
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
            Console.WriteLine("El area del rectangulo es: " + area);
            Console.Write("Su diagonal es de: " + diagonal);
            Console.ReadKey();
        }
    }
}
