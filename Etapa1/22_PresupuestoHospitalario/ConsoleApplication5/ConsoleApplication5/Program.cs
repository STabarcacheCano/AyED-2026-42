using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa su nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingresa su apellido: ");
            String apellido = Console.ReadLine();

            String nombrecompleto = nombre + " " + apellido;
            Console.WriteLine(nombrecompleto);
            Console.ReadKey();
        }
    }
}
