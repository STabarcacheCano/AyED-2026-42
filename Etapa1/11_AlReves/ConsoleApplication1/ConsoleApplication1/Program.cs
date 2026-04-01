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
                  Console.WriteLine("Buen día, ¿cómo estás?");

        Console.WriteLine("¿Cómo es tu DNI?");
        string DNI = Console.ReadLine();
            double ddato = Double.Parse(DNI);
            Console.WriteLine("Su DNI es:, " + DNI);


         
          Console.ReadKey();
            }
        }
    }
