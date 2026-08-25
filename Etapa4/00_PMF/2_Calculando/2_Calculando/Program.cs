using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            int opción = 1;
            while(opción != 5)
            {
                Console.Clear();

                Console.WriteLine("Cual opción elegis: ");

                Console.WriteLine("\n1) Sumar 2 números ");
                Console.WriteLine("2) Restar 2 números ");
                Console.WriteLine("3) Multiplicar 2 números ");
                Console.WriteLine("4) Dividir 2 números ");
                Console.WriteLine("5) SALIR ");

                Console.Write("\nLa opción: ");
                opción = int.Parse(Console.ReadLine());

                int a = 0;
                int b = 0;

                if (opción != 5)
                {
                    Console.Write("Ingresar el primer número: ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Ingresar el segundo número: ");
                    b = int.Parse(Console.ReadLine());
                }

                Calculadora(opción, a, b);
            }
           
            Console.ReadKey();
        }
        static void Calculadora(int op, int a, int b)
        {
            switch (op)
            {
                default:
                    Console.Clear();

                    Console.WriteLine("Opción no valida");

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 1:
                    Console.Clear();

                    sumar(a, b);

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();

                    restar(a, b);

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();

                    multiplicar(a, b);

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();

                    dividir(a, b);

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();

                    Console.Write("Saliste del programa.");

                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        static void sumar(int n, int n2)
        {
            int resultado = n + n2;
            Console.WriteLine("La suma de ambos números es: " + resultado);
        }

        static void restar(int n, int n2)
        {
            int resultado = n - n2;
            Console.WriteLine("La resta de ambos números es: " + resultado);
        }

        static void multiplicar (int n, int n2)
        {
            int resultado = n * n2;
            Console.WriteLine("La multiplicación de ambos números es: " + resultado);
        }
        static void dividir (int n, int n2)
        {
            int resultado = n / n2;
            Console.WriteLine("La divición de ambos números es: " + resultado);
        }
    }
}
