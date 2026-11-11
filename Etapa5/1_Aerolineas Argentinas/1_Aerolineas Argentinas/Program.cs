using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Aerolineas_Argentinas
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra[] compras = new Compra[10];

            double recaudacion = 0;
            int asientos = 0;
            double promedio = 0;
            int compras_mayores = 0;
            double mayor_importe = 0;
            string pasajero_mayor = "";
            string destino_mayor = "";

            Console.WriteLine("=== SISTEMA DE VENTA DE PASAJES ===");

            
            for (int i = 0; i < 10; i++)
            {
                int codigo;
                string pasajero;
                string destino;
                double precio;
                int cantidad;

                Console.WriteLine("\nCompra numero " + (i + 1));

                Console.Write("Ingrese el codigo: ");
                codigo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el nombre del pasajero: ");
                pasajero = Console.ReadLine();

                Console.Write("Ingrese el destino: ");
                destino = Console.ReadLine();

                Console.Write("Ingrese el precio de cada pasaje: ");
                precio = double.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de asientos: ");
                cantidad = int.Parse(Console.ReadLine());

                compras[i] = new Compra(codigo, pasajero, destino, precio, cantidad);
            }
            
            Console.WriteLine("\n=== RESUMEN DE COMPRAS ===");

            for (int i = 0; i < 10; i++)
            {
                compras[i].MostrarInformacion();

                recaudacion = recaudacion + compras[i].CalcularTotal();
                asientos = asientos + compras[i].get_asientos();

                if (compras[i].CalcularTotal() > 200000)
                {
                    compras_mayores++;
                }

                if (compras[i].CalcularTotal() > mayor_importe)
                {
                    mayor_importe = compras[i].CalcularTotal();
                    pasajero_mayor = compras[i].get_pasajero();
                    destino_mayor = compras[i].get_destino();
                }
            }
            
            promedio = recaudacion / 10;

            double porcentaje = compras_mayores * 100 / 10;
            
            Console.WriteLine("\n=== ESTADISTICAS DE VENTAS ===");

            Console.WriteLine("Recaudacion total: $" + recaudacion);
            Console.WriteLine("Cantidad total de asientos vendidos: " + asientos);
            Console.WriteLine("Importe promedio de las compras: $" + promedio);
            Console.WriteLine("Pasajero de mayor compra: " + pasajero_mayor);
            Console.WriteLine("Compras superiores a $200.000: " + compras_mayores);
            Console.WriteLine("Porcentaje de compras superiores a $200.000: " + porcentaje + "%");
            Console.WriteLine("Destino de la compra de mayor importe: " + destino_mayor);

            Console.ReadKey();
        }
    }

    class Compra
    {
        private int codigo;
        private string pasajero;
        private string destino;
        private double precio;
        private int asientos;

        public Compra(int codigo, string pasajero, string destino, double precio, int asientos)
        {
            this.codigo = codigo;
            this.pasajero = pasajero;
            this.destino = destino;
            this.precio = precio;
            this.asientos = asientos;
        }

        public int get_asientos()
        {
            return asientos;
        }

        public string get_pasajero()
        {
            return pasajero;
        }

        public string get_destino()
        {
            return destino;
        }

        public double CalcularTotal()
        {
            return precio * asientos;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("\nCodigo: " + codigo);
            Console.WriteLine("Pasajero: " + pasajero);
            Console.WriteLine("Destino: " + destino);
            Console.WriteLine("Precio individual: $" + precio);
            Console.WriteLine("Cantidad de asientos: " + asientos);
            Console.WriteLine("Importe total: $" + CalcularTotal());
        }
    }
}
