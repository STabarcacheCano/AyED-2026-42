using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número: ");
            double num = double.Parse(Console.ReadLine());

            double cuadrado = num * num
            double cubo = num * num * num

            Console.WriteLine("El cuadrado es: " + cuadrado);
            Console.WriteLine("El cubo es: " + cubo);

            Console.ReadKey();
        }
    }
}
