using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Eternauta
{
    class Program
    {
        static void Main(string[] args)
        {
            Refugio Refugio_101 = new Refugio(101, 20, 12);
            Refugio Refugio_102 = new Refugio(102, 15, 10);
            Refugio Refugio_103 = new Refugio(103, 30, 25);

            Console.WriteLine("=== SISTEMA DE REFUGIOS ===");
            Refugio_101.MostrarInformacion();
            Console.WriteLine("Disponibles: " + Refugio_101.CalcularDisponibles());

            Refugio_102.MostrarInformacion();
            Console.WriteLine("Disponibles: " + Refugio_102.CalcularDisponibles());

            Refugio_103.MostrarInformacion();
            Console.WriteLine("Disponibles: " + Refugio_103.CalcularDisponibles());

            Console.WriteLine("\n=== RESUMEN ===\n");
            Console.WriteLine("Personas alojadas: " + (Refugio_101.get_alojadas() + Refugio_102.get_alojadas() + Refugio_103.get_alojadas()));
            Console.WriteLine("Lugares disponibles: " + (Refugio_101.CalcularDisponibles() + Refugio_102.CalcularDisponibles() + Refugio_103.CalcularDisponibles()));

            if (Refugio_101.getcap() > Refugio_102.getcap() && Refugio_101.getcap() > Refugio_103.getcap())
            {
                Console.WriteLine("Refugio de mayor capacidad: 101");
            }
            else if(Refugio_102.getcap() > Refugio_101.getcap() && Refugio_102.getcap() > Refugio_103.getcap())
            {
                Console.WriteLine("Refugio de mayor capacidad: 102");
            }
            else
            {
                Console.WriteLine("Refugio de mayor capacidad: 103");
            }

            Console.ReadKey();
        }

    }

    class Refugio
    {
        private int codigo;
        private int cap_maxima;
        private int pers_alojadas;

        public Refugio (int codigo, int cap_maxima, int pers_alojadas)
        {
            this.codigo = codigo;
            this.cap_maxima = cap_maxima;
            this.pers_alojadas = pers_alojadas;
        }

        public int get_alojadas()
        {
            return pers_alojadas;
        }

        public int getcap()
        {
            return cap_maxima;
        }

        public int CalcularDisponibles()
        {
            return cap_maxima - pers_alojadas;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("\nRefugio: " + codigo);
            Console.WriteLine("Capacidad: " + cap_maxima);
            Console.WriteLine("Alojados: "  + pers_alojadas);
        }


    }
}
