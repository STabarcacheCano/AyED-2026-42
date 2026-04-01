using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapaciadadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la cantiadad de cilindros: ");
            float cantidad_Cilindros = float.Parse(Console.ReadLine());
            Console.Write("Ingresar la cantidad de pistas que tiene el cilindro: ");
            float cantidad_Pistas = float.Parse(Console.ReadLine());
            Console.Write("Ingresar las cantidades de sectores que tiene cada pista: ");
            float cantidad_Sectores = float.Parse(Console.ReadLine());
            float resultado = cantidad_Sectores * 512;
            float bytes_Pistas = resultado * cantidad_Pistas;
            float bytes_Cilidros = bytes_Pistas * cantidad_Cilindros;
            float kilobytes = bytes_Cilidros / 1024;
            float megabytes = kilobytes / 1024;
            float gigabytes = megabytes / 1024;
            Console.Write("La capacidad total en kilobytes es " + kilobytes + " en megabytes son " + megabytes + " y en gigabytes " + gigabytes);
            Console.ReadKey();

        }
    }
}
