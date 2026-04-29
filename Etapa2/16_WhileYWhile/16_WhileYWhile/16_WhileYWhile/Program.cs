using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números impares del 0 al 100:");
            Console.WriteLine("");
            int num = 0;
            while (num <= 100)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + "-");
                }
                num++;
            }

            num = 0;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Números pares del 0 al 100:");
            Console.WriteLine("");

            while (num <= 100)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + "-");
                }

                num++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Números del 0 al 100:");
            Console.WriteLine("");

            num = 0;

            while (num <= 100)
            {
                Console.Write(num + "-");
                num++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Números del 100 al 0:");
            Console.WriteLine("");

            num = 100;

            while (num >= 0)
            {
                Console.Write(num + "-");

                num -= 1;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Números multiplos de 3, del 0 al 100:");
            Console.WriteLine("");

            num = 0;

            while (num <= 100)
            {
                if (num % 3 == 0)
                {
                    Console.Write(num + "-");
                }
                num++;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Números multiplos de 3 y 2, del 0 al 100:");
            Console.WriteLine("");

            num = 0;

            while (num <= 100)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + "-");
                }
                else
                {
                    if (num % 3 == 0)
                    {
                        Console.Write(num + "-");
                    }
                }

                num++;
            }

            Console.ReadKey();
        }
    }
}
