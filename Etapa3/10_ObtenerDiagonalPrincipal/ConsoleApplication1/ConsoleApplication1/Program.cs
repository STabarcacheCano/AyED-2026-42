using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numeros = new int[10];

    
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine("Números ordenados:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num + " ");
            }
            
            Console.WriteLine("Ingrese un número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            bool encontrado = false;

            foreach (int num in numeros)
            {
                if (num == buscar)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("El número sí está en la lista.");
            }
            else
            {
                Console.WriteLine("no esta en la lista el numero ingresado");
                if(encontrado = true)
                {
                    Console.WriteLine("Ingrese un número a buscar: ");
                    int bus = int.Parse(Console.ReadLine());
                    foreach (int num in numeros)
                    {
                        if (num == buscar)
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        Console.WriteLine("El número sí está en la lista.");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
