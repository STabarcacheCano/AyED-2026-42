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
            string profesion; 
            Console.Write( "Ecoje entre las siguientes profeciones para trabajar de grande. Medicina, cirujano, psicologo, negocio propio o asistente de presidencia: ");
            profesion = Console.ReadLine();
            switch (profesion)
            {
                case "Medicina":
                case "cirujano": Console.WriteLine("millonario");
                    break;
                case "psicologo": Console.WriteLine("podre endeudado");
                    break;
                case "negocio propio": Console.WriteLine("dependera que tan buena sea la gestion");
                    break;
                case "asistente de presidencia": Console.WriteLine("betty la fea referencia");
                    break;
                default:
                    Console.WriteLine("Usuario no valido");
                    break;

            }
    }
}
