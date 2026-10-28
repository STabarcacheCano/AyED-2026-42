using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mate mateFran = new Mate(10 ,4, 70, true, "madera");
            

            Console.WriteLine("\t MateFRan \n");
            Console.WriteLine("Cantidad de Agua: " + mateFran.getcantAgua());
            mateFran.cebar();
            Console.WriteLine("Cantidad de Agua: " + mateFran.getcantAgua());
            mateFran.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + mateFran.getcantAgua());

            Console.ReadKey();
            Console.Clear();

            Mate mateRojo = new Mate(8, 3, 70, false, "vidrio");
            
            Console.WriteLine("\t MateRojo \n");
            Console.WriteLine("Cantidad de Agua: " + mateRojo.getcantAgua());
            mateRojo.cebar();
            Console.WriteLine("Cantidad de Agua: " + mateRojo.getcantAgua());
            mateRojo.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + mateRojo.getcantAgua());
            Console.ReadKey();
            Console.Clear();

            Mate metal_chico = new Mate(5, 2, 50, false, "aluminio");

            Console.WriteLine("\t metal_chico \n");
            Console.WriteLine("Cantidad de Agua: " + metal_chico.getcantAgua());
            metal_chico.cebar();
            Console.WriteLine("Cantidad de Agua: " + metal_chico.getcantAgua());
            metal_chico.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + metal_chico.getcantAgua());
            Console.ReadKey();
            Console.Clear();

            Mate ceramicaMate = new Mate(8,3, 50, false, "ceramica");

            Console.WriteLine("\t ceramicaMate \n");
            Console.WriteLine("Cantidad de Agua: " + ceramicaMate.getcantAgua());
            ceramicaMate.cebar();
            Console.WriteLine("Cantidad de Agua: " + ceramicaMate.getcantAgua());
            ceramicaMate.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + ceramicaMate.getcantAgua());
            Console.ReadKey();
            Console.Clear();

            Mate matePatas = new Mate(10, 3, 70, true, "aluminio");

            Console.WriteLine("\t Mate_patas \n");
            Console.WriteLine("Cantidad de Agua: " + matePatas.getcantAgua());
            matePatas.cebar();
            Console.WriteLine("Cantidad de Agua: " + matePatas.getcantAgua());
            matePatas.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + matePatas.getcantAgua());
            Console.ReadKey();
            Console.Clear();

            Mate matePlateado = new Mate(10, 2, 60, false , "aluminio");

            Console.WriteLine("\t Mateplateado \n");
            Console.WriteLine("Cantidad de Agua: " + matePlateado.getcantAgua());
            matePlateado.cebar();
            Console.WriteLine("Cantidad de Agua: " + matePlateado.getcantAgua());
            matePlateado.tomar(20);
            Console.WriteLine("Cantidad de Agua: " + matePlateado.getcantAgua());


            Console.ReadKey();
        }
    }

    class Mate
    {
        private int altura;
        private int radio;
        private int capacidad;
        private bool tieneBombilla;
        private string material;
        private int cantAgua = 0;

        public Mate(int altura, int radio, int capacidad, bool tieneBombilla, string material)
        {
            this.altura = altura;
            this.radio = radio;
            this.capacidad = capacidad;
            this.tieneBombilla = tieneBombilla;
            this.material = material;
        }

        public int getcantAgua()
        {
            return cantAgua;
        }

        public void cebar()
        {
            cantAgua = capacidad;
        }

        public void tomar( int cant)
        {
            cantAgua -= cant;
        }
    }
}
