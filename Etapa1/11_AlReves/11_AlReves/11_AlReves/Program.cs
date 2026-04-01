using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Intrudusca tres letras: ");
            String letras = Console.ReadLine();
            Console.WriteLine("Las letras en el orden al reves son:");
            Console.WriteLine(letras[2]);
            Console.WriteLine(letras[1]);
            Console.Write(letras[0]);
            Console.ReadKey();
        }
    }
}
