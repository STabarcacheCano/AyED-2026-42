using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AvengersAir
{
    class Program
    {
        static void Main()
        {
            string[,] asientos = new string[80, 8];
    
            int opcion = 0;
    
            
    
            for (int i = 0; i < 80; i++)
            {
                asientos[i, 0] = (i + 1).ToString();
    
                if (i < 20)
                {
                    asientos[i, 1] = "Primera clase";
                }
                else if (i >= 39 && i <= 42)
                {
                    asientos[i, 1] = "Emergencia";
                }
                else
                {
                    asientos[i, 1] = "Economica";
                }
    
                asientos[i, 2] = "-";
                asientos[i, 3] = "-";
                asientos[i, 4] = "-";
                asientos[i, 5] = "-";
                asientos[i, 6] = "-";
                asientos[i, 7] = "No";
            }
            
    
            while (opcion != 7)
            {
                Console.Clear();
    
                int disponibles = 0;
                int ocupados = 0;
    
                for (int i = 0; i < 80; i++)
                {
                    if (asientos[i, 7] == "No")
                    {
                        disponibles++;
                    }
                    else
                    {
                        ocupados++;
                    }
                }
    
                Console.WriteLine("====================================");
                Console.WriteLine(" AVENGERSAIR - BUENOS AIRES A WAKANDA");
                Console.WriteLine("====================================");
    
                Console.WriteLine("Asientos disponibles: " + disponibles);
                Console.WriteLine("Asientos ocupados: " + ocupados);
    
                Console.WriteLine();
                Console.WriteLine("1. Vender Asiento");
                Console.WriteLine("2. Devolver Asiento");
                Console.WriteLine("3. Modificar Asiento");
                Console.WriteLine("4. Calcular Ventas");
                Console.WriteLine("5. Buscar Pasajeros por Edad");
                Console.WriteLine("6. Obtener Asientos con DNI Par");
                Console.WriteLine("7. Salir");
    
                Console.WriteLine();
                Console.Write("Ingrese la opcion deseada: ");
    
                opcion = int.Parse(Console.ReadLine());
    
                Console.Clear();
    
                switch (opcion)
                {
                   
    
                    case 1:
    
                        Console.WriteLine("ASIENTOS DISPONIBLES");
                        Console.WriteLine("------------------------------------");
    
                        Console.WriteLine("N° | Tipo de Asiento");
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "No")
                            {
                                Console.WriteLine(
                                    asientos[i, 0] + " | " +
                                    asientos[i, 1]);
                            }
                        }
    
                        Console.WriteLine();
                        Console.Write("Ingrese el numero de asiento: ");
    
                        int numero = int.Parse(Console.ReadLine());
    
                        int fila = numero - 1;
    
                        if (fila < 0 || fila >= 80)
                        {
                            Console.WriteLine("Numero de asiento incorrecto.");
                        }
                        else if (asientos[fila, 7] == "Si")
                        {
                            Console.WriteLine("El asiento esta ocupado.");
                        }
                        else
                        {
                            Console.Write("Nombre: ");
                            asientos[fila, 2] = Console.ReadLine();
    
                            Console.Write("Apellido: ");
                            asientos[fila, 3] = Console.ReadLine();
    
                            Console.Write("Edad: ");
                            asientos[fila, 4] = Console.ReadLine();
    
                            Console.Write("DNI: ");
                            asientos[fila, 5] = Console.ReadLine();
    
                            Console.Write("Nacionalidad: ");
                            asientos[fila, 6] = Console.ReadLine();
    
                            asientos[fila, 7] = "Si";
    
                            Console.WriteLine();
                            Console.WriteLine("Asiento vendido correctamente.");
                        }
    
                        break;
                        
    
                    case 2:
    
                        Console.WriteLine("ASIENTOS OCUPADOS");
                        Console.WriteLine("------------------------------------");
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "Si")
                            {
                                Console.WriteLine(
                                    "Asiento: " + asientos[i, 0] +
                                    " | Nombre: " + asientos[i, 2] +
                                    " | Apellido: " + asientos[i, 3]);
                            }
                        }
    
                        Console.WriteLine();
                        Console.Write("Ingrese el numero de asiento: ");
    
                        numero = int.Parse(Console.ReadLine());
    
                        fila = numero - 1;
    
                        if (fila < 0 || fila >= 80)
                        {
                            Console.WriteLine("Numero de asiento incorrecto.");
                        }
                        else if (asientos[fila, 7] == "No")
                        {
                            Console.WriteLine("El asiento ya esta libre.");
                        }
                        else
                        {
                            asientos[fila, 2] = "-";
                            asientos[fila, 3] = "-";
                            asientos[fila, 4] = "-";
                            asientos[fila, 5] = "-";
                            asientos[fila, 6] = "-";
                            asientos[fila, 7] = "No";
    
                            Console.WriteLine("Asiento devuelto correctamente.");
                        }
    
                        break;
                        
    
                    case 3:
    
                        Console.WriteLine("ASIENTOS OCUPADOS");
                        Console.WriteLine("------------------------------------");
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "Si")
                            {
                                Console.WriteLine(
                                    asientos[i, 0] + " | " +
                                    asientos[i, 2] + " | " +
                                    asientos[i, 3] + " | " +
                                    asientos[i, 4] + " | " +
                                    asientos[i, 5]);
                            }
                        }
    
                        Console.WriteLine();
                        Console.Write("Ingrese el numero de asiento: ");
    
                        numero = int.Parse(Console.ReadLine());
    
                        fila = numero - 1;
    
                        if (fila < 0 || fila >= 80)
                        {
                            Console.WriteLine("Numero de asiento incorrecto.");
                        }
                        else if (asientos[fila, 7] == "No")
                        {
                            Console.WriteLine("El asiento no esta ocupado.");
                        }
                        else
                        {
                            Console.Write("Nuevo nombre: ");
                            asientos[fila, 2] = Console.ReadLine();
    
                            Console.Write("Nuevo apellido: ");
                            asientos[fila, 3] = Console.ReadLine();
    
                            Console.Write("Nueva edad: ");
                            asientos[fila, 4] = Console.ReadLine();
    
                            Console.Write("Nuevo DNI: ");
                            asientos[fila, 5] = Console.ReadLine();
    
                            Console.Write("Nueva nacionalidad: ");
                            asientos[fila, 6] = Console.ReadLine();
    
                            Console.WriteLine("Datos modificados correctamente.");
                        }
    
                        break;
                        
    
                    case 4:
    
                        decimal total = 0;
    
                        int primera = 0;
                        int emergencia = 0;
                        int economica = 0;
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "Si")
                            {
                                if (asientos[i, 1] == "Primera clase")
                                {
                                    total += 200;
                                    primera++;
                                }
                                else if (asientos[i, 1] == "Emergencia")
                                {
                                    total += 80;
                                    emergencia++;
                                }
                                else
                                {
                                    total += 100;
                                    economica++;
                                }
                            }
                        }
    
                        Console.WriteLine("RECAUDACION DEL VUELO");
                        Console.WriteLine("------------------------------------");
    
                        Console.WriteLine("Primera clase: " + primera);
                        Console.WriteLine("Salidas de emergencia: " + emergencia);
                        Console.WriteLine("Economica regular: " + economica);
    
                        Console.WriteLine();
                        Console.WriteLine("Total recaudado: $" + total);
    
                        break;
                        
    
                    case 5:
    
                        Console.Write("Ingrese la edad que desea buscar: ");
    
                        int edadBuscada = int.Parse(Console.ReadLine());
    
                        bool encontrado = false;
    
                        Console.WriteLine();
                        Console.WriteLine("PASAJEROS ENCONTRADOS");
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "Si")
                            {
                                if (int.Parse(asientos[i, 4]) == edadBuscada)
                                {
                                    Console.WriteLine(
                                        "Asiento: " + asientos[i, 0] +
                                        " | Nombre: " + asientos[i, 2] +
                                        " | Apellido: " + asientos[i, 3] +
                                        " | Edad: " + asientos[i, 4]);
    
                                    encontrado = true;
                                }
                            }
                        }
    
                        if (encontrado == false)
                        {
                            Console.WriteLine("No se encontraron pasajeros.");
                        }
    
                        break;
                        
    
                    case 6:
    
                        encontrado = false;
    
                        Console.WriteLine("ASIENTOS CON DNI PAR");
                        Console.WriteLine("------------------------------------");
    
                        for (int i = 0; i < 80; i++)
                        {
                            if (asientos[i, 7] == "Si")
                            {
                                long dni = long.Parse(asientos[i, 5]);
    
                                if (dni % 2 == 0)
                                {
                                    Console.WriteLine(
                                        "Asiento: " + asientos[i, 0] +
                                        " | DNI: " + asientos[i, 5]);
    
                                    encontrado = true;
                                }
                            }
                        }
    
                        if (encontrado == false)
                        {
                            Console.WriteLine("No hay pasajeros con DNI par.");
                        }
    
                        break;
                        
    
                    case 7:
    
                        Console.WriteLine("Gracias por utilizar AvengersAir.");
    
                        break;
    
                    default:
    
                        Console.WriteLine("Opcion incorrecta.");
    
                        break;
                }
    
                if (opcion != 7)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
