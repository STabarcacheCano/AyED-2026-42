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
            string[,] datos_usuario = new string[80, 8];
            int[,] Mapa_Asientos = new int[20, 4];
            
            int contador_asientos = 2;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ( j == 0)
                    {
                        Mapa_Asientos[i, j] = contador_asientos;
                        contador_asientos--;
                    }
                    else if( j == 1 )
                    {
                        Mapa_Asientos[i, j] = contador_asientos;
                        contador_asientos+=2;
                    }
                    else if( j == 3)
                    {
                        Mapa_Asientos[i, j] = contador_asientos;
                        contador_asientos+=2;
                    }
                    else
                    {
                        Mapa_Asientos[i, j] = contador_asientos;
                        contador_asientos++;
                    }
                }
            }
            

            for (int i = 0; i < 20; i++)
            {
                datos_usuario[i, 7] = "desocupado" ;
            }

            int opción = 0;
            int asientos_disponibles = 80;
            int asientos_ocupados = 0;

            while(opción != 7)
            {
                Console.Clear();
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
                                    Console.Write(Mapa_Asientos[i, j] + "\n");
                                }
                                else if (j == 1)
                                {
                                    Console.Write(Mapa_Asientos[i, j] + "\t");
                                }
                                else
                                {
                                    Console.Write("\t" + Mapa_Asientos[i, j] + "-");
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
                                        Console.Write(Mapa_Asientos[i, j] + "\t");
                                    }
                                    else 
                                    {
                                        Console.Write("\t" + Mapa_Asientos[i, j] + "-");
                                    }
                                }
                                else
                                {
                                    if (j == 3)
                                    {
                                        Console.Write(Mapa_Asientos[i, j] + "\n");
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
                                    Console.Write(Mapa_Asientos[i, j] + "\n");
                                }
                                else if (j == 1)
                                {
                                    Console.Write(Mapa_Asientos[i, j] + "\t");
                                }
                                else
                                {
                                    Console.Write("\t" + Mapa_Asientos[i, j] + "-");
                                }
                            }

                        }

                        Console.Write("\n Elegí el número de asiento: ");
                        string asiento_eleg = Console.ReadLine();
                        int asiento_elegido = int.Parse(asiento_eleg);
                        datos_usuario[(asiento_elegido - 1), 0] = asiento_eleg;
                        if (asiento_elegido < 21)
                        {
                            datos_usuario[(asiento_elegido - 1), 1] = "Primera Clase";
                        }
                        else if (asiento_elegido >= 40 && asiento_elegido <= 43)
                        {
                            datos_usuario[(asiento_elegido - 1), 1] = "Salidas de Emergencia";
                        }
                        else
                        {
                            datos_usuario[(asiento_elegido - 1), 1] = "Clase Económica";
                        }
                        Console.Write("\n Ingrese su Nombre: ");
                        datos_usuario[(asiento_elegido - 1), 2] = Console.ReadLine();
                        Console.Write("\n Ingrese su Apellido: ");
                        datos_usuario[(asiento_elegido - 1), 3] = Console.ReadLine();
                        Console.Write("\n Ingrese su Edad: ");
                        datos_usuario[(asiento_elegido - 1), 4] = Console.ReadLine();
                        Console.Write("\n Ingrese su Nacionalidad: ");
                        datos_usuario[(asiento_elegido - 1), 6] = Console.ReadLine();
                        Console.Write("\n Ingrese su DNI: ");
                        datos_usuario[(asiento_elegido - 1), 5] = Console.ReadLine();
                        datos_usuario[(asiento_elegido - 1), 7] = "Ocupado";

                        asientos_disponibles--;
                        asientos_ocupados++;
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("\n N° asiento \t Tipo de Asiento \t  Nombre \t  Apellido \t  Edad \t  DNI \t  Nacionalidad \t  Ocupado \n");
                        for (int i = 0; i < 80; i++)
                        {
                            
                            if (datos_usuario[i, 7] == "Ocupado")
                            {
                                for(int h= 0; h < 8; h++)
                                {
                                    if( h == 7)
                                    {
                                        Console.Write("\t |" + datos_usuario[i, h] + "\n");
                                    }
                                    else
                                    {
                                        Console.Write("\t |" + datos_usuario[i, h]);
                                    }
                                }
                            }
                        }
                        Console.Write("\n De que número es el asiento que desea modificar?");
                        int moficar = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n \t Que desea modificar? \n");
                        Console.WriteLine("1) Nombre");
                        Console.WriteLine("2) Apellido");
                        Console.WriteLine("3) Edad");
                        Console.WriteLine("4) DNI");
                        Console.WriteLine("5) Nacionalidad");
                        Console.Write("\n \t Escribe la opción elegida: ");
                        string op = Console.ReadLine();

                        Console.Clear();
                        switch (op)
                        {
                            case "1":
                                Console.Write("\n Ingresar el Nombre que desea: ");
                                datos_usuario[(moficar - 1), 2] = Console.ReadLine();
                                break;
                            case "2":
                                Console.Write("\n Ingresar el Apellido que desea: ");
                                datos_usuario[(moficar - 1), 3] = Console.ReadLine();
                                break;
                            case "3":
                                Console.Write("\n Ingresar el Edad que desea: ");
                                datos_usuario[(moficar - 1), 4] = Console.ReadLine();
                                break;
                            case "4":
                                Console.Write("\n Ingresar el DNI desea: ");
                                datos_usuario[(moficar - 1), 5] = Console.ReadLine();
                                break;
                            case "5":
                                Console.Write("\n Ingresar el Nacionalidad que desea: ");
                                datos_usuario[(moficar - 1), 6] = Console.ReadLine();
                                break;
                        }
                        for (int i = 0; i < 8; i++)
                        {
                            Console.Write(datos_usuario[(moficar - 1), i] + "\t ");
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("\t Asientos vendidos: " + asientos_ocupados);
                        int recaudación = 0;
                        for (int i = 0; i < 80; i++)
                        {
                            if (datos_usuario[i, 1] == "Primera Clase")
                            {
                                recaudación += 200;
                            }
                            else if (datos_usuario[i, 1] == "Salidas de Emergencia")
                            {
                                recaudación += 80;
                            }
                            else if (datos_usuario[i, 1] == "Clase Económica")
                            {
                                recaudación += 100;
                            }
                        }

                        Console.Write("\t Recaudación total del vuelo: $" + recaudación);

                        Console.ReadKey();

                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Ingresar una edad: ");
                        string buscar = Console.ReadLine();
                       
                        for(int i = 0; i < 80; i++)
                        {
                            if (datos_usuario[i, 4] == buscar)
                            {
                                Console.WriteLine("Pasajero del asiento N° " + (i + 1) + " coincide con la edad ingresada. ");
                             
                            }
                            
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Los Pasajeros con DNI par estan en los asientos: ");
                        
                        for (int j = 0; j < 80; j++)
                        {
                            if(int.Parse(datos_usuario[j, 5]) % 2 == 0)
                            {
                                Console.Write(datos_usuario[j, 0] + ", ");
                                     
                            }
                        }

                        Console.ReadKey();
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
