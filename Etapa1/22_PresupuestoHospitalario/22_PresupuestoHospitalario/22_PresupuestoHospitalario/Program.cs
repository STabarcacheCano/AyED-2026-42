using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el presupuesto del hospital: ");
            float presupuesto = float.Parse(Console.ReadLine());
            float gin = presupuesto * 40 / 100;
            float trauYpedia = presupuesto * 30 / 100;
            Console.Write("El presupuesto para Ginecologia es " + gin + ", para Traumatología y Pediatria es de " + trauYpedia + ".");
            Console.ReadKey();
        }
    }
}
