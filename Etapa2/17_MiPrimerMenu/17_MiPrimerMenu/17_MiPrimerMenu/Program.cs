using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Bienvenido al programa");
                Console.WriteLine("");
                Console.WriteLine("-------- Menú --------");
                Console.WriteLine("1) Número Impar o Par.");
                Console.WriteLine("2) Multiplo de 3");
                Console.WriteLine("3) Multiplo de 4");
                Console.WriteLine("4) Salir del Programa");
                Console.WriteLine("");
                Console.Write("Elegir una opción:");
                int opcion = int.Parse(Console.ReadLine());

            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó la opción 1");
                        Console.WriteLine("");
                        Console.Write("Ingresar un número:");
                        int num = int.Parse(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine("Es par.");
                            Console.WriteLine("");

                        }
                        else
                        {

                            Console.WriteLine("Es Impar");
                            Console.WriteLine("");

                        }
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó la opción 2");
                        Console.WriteLine("");

                        Console.Write("Ingresar un número:");
                        int num_3 = int.Parse(Console.ReadLine());

                        if (num_3 % 3 == 0)
                        {
                            Console.WriteLine("Es multiplo de 3");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("No es multiplo de 3");
                            Console.WriteLine("");

                        }
                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Seleccionó la opción 3");
                        Console.WriteLine("");

                        Console.Write("Ingresar un número:");
                        int num_4 = int.Parse(Console.ReadLine());

                        if (num_4 % 4 == 0)
                        {
                            Console.WriteLine("Es multiplo de 4");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("No es multiplo de 4");
                            Console.WriteLine("");

                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;

                }

                Console.WriteLine("Bienvenido al programa");
                Console.WriteLine("");
                Console.WriteLine("-------- Menú --------");
                Console.WriteLine("1) Número Impar o Par.");
                Console.WriteLine("2) Multiplo de 3");
                Console.WriteLine("3) Multiplo de 4");
                Console.WriteLine("4) Salir del Programa");
                Console.WriteLine("");
                Console.Write("Elegir una opción:");
                opcion = int.Parse(Console.ReadLine());
            }

            Console.Write("Saliste del programa.");
            Console.ReadKey();
        }
    }
}
