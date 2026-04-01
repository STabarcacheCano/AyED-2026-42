using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar las horas trabajadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Ingresar cuanto le pagan por hora: ");
            int pago = int.Parse(Console.ReadLine());
            int sueldo_total = horas * pago;
            Console.Write("Su sueldo total es de: " + sueldo_total);
            Console.ReadKey();
        }
    }
}
