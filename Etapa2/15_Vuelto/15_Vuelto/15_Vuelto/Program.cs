using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar el monto total de la compra: ");
            int monto = int.Parse(Console.ReadLine());

            Console.Write("Ingresar el dinero entregado para pagar: ");
            int dinero_ingresado = int.Parse(Console.ReadLine());


            while (dinero_ingresado <= 0)
            {
                Console.Write("Ingresar el dinero entregado para pagar: ");
                dinero_ingresado = int.Parse(Console.ReadLine());


            }

            int vuelto = dinero_ingresado-monto;

            int cantidad_de_10000 = 0;
            int cantidad_de_2000 = 0;
            int cantidad_de_1000 = 0;
            int cantidad_de_500 = 0;
            int cantidad_de_200 = 0;
            int cantidad_de_100 = 0;
            int cantidad_de_50 = 0;
            int cantidad_de_20 = 0;
            int cantidad_de_10 = 0;
            int cantidad_de_1 = 0;
       

            while (vuelto != 0)
            {
                if (vuelto >= 10000)
                {
                    cantidad_de_10000 ++;
                    vuelto -= 10000;
                }else

                if (vuelto >= 2000)
                {
                    cantidad_de_2000 ++;
                    vuelto -= 2000;
                }
                else if (vuelto >= 1000)
                {
                    cantidad_de_1000 ++;
                    vuelto -= 1000;
                }
                else if (vuelto >= 500)
                {
                    cantidad_de_500 ++;
                    vuelto -= 500;
                }
                else if (vuelto >= 200)
                {
                    cantidad_de_200 ++;
                    vuelto -= 200;
                }
                else if (vuelto >= 100)
                {
                    cantidad_de_100 ++;
                    vuelto -= 100;
                }
                else if (vuelto >= 50)
                {
                    cantidad_de_50 ++;
                    vuelto -= 50;
                }
                else if (vuelto >= 20)
                {
                    cantidad_de_20 ++;
                    vuelto -= 20;
                }
                else if (vuelto >= 10)
                {
                    cantidad_de_10 ++;
                    vuelto -= 10;
                }
                else
                {
                    cantidad_de_1 ++;
                    vuelto -= 1;
                }

            }

            Console.WriteLine("Cantidad de billetes de $10.000: " + cantidad_de_10000);
            Console.WriteLine("Cantidad de billetes de $2.000: " + cantidad_de_2000);
            Console.WriteLine("Cantidad de billetes de $1.000: " + cantidad_de_1000);
            Console.WriteLine("Cantidad de billetes de $500: " + cantidad_de_500);
            Console.WriteLine("Cantidad de billetes de $200: " + cantidad_de_200);
            Console.WriteLine("Cantidad de billetes de $100: " + cantidad_de_100);
            Console.WriteLine("Cantidad de billetes de $50: " + cantidad_de_50);
            Console.WriteLine("Cantidad de billetes de $20: " + cantidad_de_20);
            Console.WriteLine("Cantidad de billetes de $10: " + cantidad_de_10);
            Console.WriteLine("Cantidad de billetes de $1: " + cantidad_de_1);



            Console.ReadKey();

            
        }
    }
}
