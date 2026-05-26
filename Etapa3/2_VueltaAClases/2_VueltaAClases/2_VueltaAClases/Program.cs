using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de TPs : ");
            int[] TPs = new int[(int.Parse(Console.ReadLine()))];

            Console.Write("Ingresar cantidad de Examenes : ");
            int[] examenes = new int[(int.Parse(Console.ReadLine()))];

            int suma_examenes = 0;

            for (int i = 0; i < examenes.Length; i++)
            {
                Console.Write("Ingresar nota de la prueba " + (i + 1) + " : ");
                int nota = int.Parse(Console.ReadLine());

                suma_examenes += nota;

            }

            int promedio_examenes = suma_examenes / examenes.Length;
            int Tps_aprovados = 0;

            for (int i = 0; i < TPs.Length; i++)
            {
                Console.Write("Ingresar nota del TP " + (i + 1) + " : ");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 6)
                {
                    Tps_aprovados++;
                }
            }

            float porcentaje_aprovados = (TPs.Length / 4) * 3;

            

            if (promedio_examenes >= 6 && Tps_aprovados >= porcentaje_aprovados)
            {
                Console.Clear();
                Console.WriteLine("Phineas y Ferb, aprueban");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Phineas y Ferb, no aprueban");
            }

            Console.ReadKey();
        }
    }
}
