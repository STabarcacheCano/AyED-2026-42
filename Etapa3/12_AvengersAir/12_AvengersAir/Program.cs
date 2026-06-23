using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] datos_usuario = new int[80, 6];
            int[,] matriz = new int[20, 4];
            int[,] asientos = new int[20, 4];
            int contador_asientos = 1;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = contador_asientos++;
                }
            }

           for (int k = 0; k < 20; k++)
            {
                for (int h = 0; h < 4; h++)
                {
                    if(h == 0)
                    {
                        asientos[k, h] = matriz[k, (h + 1)];

                    }
                    else if (h == 1)
                    {
                        asientos[k, h] = matriz[k, (h - 1)];
                    }
                    else
                    {
                        asientos[k, h] = matriz[k, h];
                    }
                }

            }

            int opción = 0;
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;
            while(opción != 7)
            {
                Console.WriteLine("Asientos disponibles: " + asientos_disponibles);
                Console.WriteLine("Asientos ocupados: " + asientos_ocupados + "\n");

                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos por DNI Par");
                Console.WriteLine("7. Salir \n");

                Console.Write("Elegir una opción: ");
                opción = int.Parse(Console.ReadLine());

                switch (opción)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" \n \t   Primera Clase \n");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (j == 3)
                                {
                                    Console.Write( asientos[i, j] + "\n");
                                }
                                else if (j == 1)
                                {
                                    Console.Write(asientos[i, j] + "\t");
                                }
                                else
                                {
                                    Console.Write("\t" + asientos[i, j] + "-");
                                }
                            }
                            
                        }

                        Console.WriteLine(" \n  \t Salida de Emergencia \n");

                        for(int i = 9; i < 11; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {

                                if ( i == 10)
                                {
                                    if (j == 3)
                                    {
                                        Console.Write("XX" + "\n");
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Write(asientos[i, j] + "\t");
                                    }
                                    else 
                                    {
                                        Console.Write("\t" + asientos[i, j] + "-");
                                    }
                                }
                                else
                                {
                                    if (j == 3)
                                    {
                                        Console.Write(asientos[i, j] + "\n");
                                    }
                                    else if (j == 1)
                                    {
                                        Console.Write("XX" + "\t");
                                    }
                                    else
                                    {
                                        Console.Write("\t" + "XX" + "-");
                                    }
                                }
                            }
                        }
                        Console.WriteLine(" \n  \t   Clase Economica \n");
                        for (int i = 5; i < 9; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (j == 3)
                                {
                                    Console.Write(asientos[i, j] + "\n");
                                }
                                else if (j == 1)
                                {
                                    Console.Write(asientos[i, j] + "\t");
                                }
                                else
                                {
                                    Console.Write("\t" + asientos[i, j] + "-");
                                }
                            }

                        }
                        Console.Write("\n Elegí el número de asiento: ");
                        int asiento_elegido = int.Parse(Console.read)
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
