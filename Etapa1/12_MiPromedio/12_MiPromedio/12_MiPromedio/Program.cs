using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa un segundo número: ");
            float numero2 = float.Parse(Console.ReadLine());
            Console.Write("Ingresa un tercer número: ");
            float numero3 = float.Parse(Console.ReadLine());
            float sum = numero1 + numero2 + numero3;
            float promedio = sum / 3;
            Console.Write("El promedio de los tres números es: " + promedio);
            Console.ReadKey();
            

        }
    }
}
