using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar una medida de metros: ");
            int metros = int.Parse(Console.ReadLine());
            float centimetros = metros * 100;
            float milimetros = metros * 1000;
            Console.Write("En centimetros es " + centimetros + " y en milimetros es " + milimetros);
            Console.ReadKey();
        }
    }
}
