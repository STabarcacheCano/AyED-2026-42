using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de productos vendidos: ");
            int cap_del_Vector = int.Parse(Console.ReadLine());
            int[] productos_vendidos = new int[cap_del_Vector];

            if (cap_del_Vector <= 0)
            {
                Console.WriteLine("No se vendio nada por lo cúal no hay precio del producto más bajo ni alto." );
            }
            else
            {
                for (int i = 0; i < productos_vendidos.Length; i++)
                {
                    Console.Write("Ingresar el precio del producto " + (i + 1) + " : ");
                    productos_vendidos[i] = int.Parse(Console.ReadLine());
                }

                int precio_bajo = productos_vendidos[0];
                int precio_mayor = productos_vendidos[0];

                for (int i = 1; i < productos_vendidos.Length; i++)
                {
                    if (productos_vendidos[i] > precio_mayor)
                    {
                        precio_mayor = productos_vendidos[i];
                    }
                    if (productos_vendidos[i] < precio_bajo)
                    {
                        precio_bajo = productos_vendidos[i];
                    }
                }

                Console.WriteLine("El precio mayor fue : $" + precio_mayor);
                Console.WriteLine("El precio menor fue : $" + precio_bajo);

            }

            Console.ReadKey();
        }
    }
}
