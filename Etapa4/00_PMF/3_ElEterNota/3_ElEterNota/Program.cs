using System;

class Program
{
    
    static void Main()
    {
        int[,] refugios = new int[20, 5];

        int cantidadRefugios = 0;
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
            Console.WriteLine("1. Agregar refugio");
            Console.WriteLine("2. Mostrar todos los refugios");
            Console.WriteLine("3. Ocupar refugio");
            Console.WriteLine("4. Mostrar ocupados");
            Console.WriteLine("5. Refugio con más suministros");
            Console.WriteLine("6. Promedio por zona");
            Console.WriteLine("7. Filtrar por zona");
            Console.WriteLine("8. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    cantidadRefugios = AgregarRefugio(refugios, cantidadRefugios);
                    break;

                case 2:
                    MostrarRefugios(refugios, cantidadRefugios);
                    break;

                case 3:
                    OcuparRefugio(refugios, cantidadRefugios);
                    break;

                case 4:
                    MostrarOcupados(refugios, cantidadRefugios);
                    break;

                case 5:
                    MasSuministros(refugios, cantidadRefugios);
                    break;

                case 6:
                    PromedioPorZona(refugios, cantidadRefugios);
                    break;

                case 7:
                    FiltrarPorZona(refugios, cantidadRefugios);
                    break;

                case 8:
                    Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            if (opcion != 8)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 8);
        Console.ReadKey();
    }

    static void FiltrarPorZona(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            int zona;
            bool valido = false;

            while (!valido)
            {
                Console.Write("Ingrese una zona (1 a 4): ");
                zona = int.Parse(Console.ReadLine());

                if (zona < 1 || zona > 4)
                {
                    Console.WriteLine("Zona inválida, esa parte ya está perdida");
                }
                else
                {
                    valido = true;

                    bool encontrado = false;

                    for (int i = 0; i < cantidadRefugios; i++)
                    {
                        if (refugios[i, 3] == zona)
                        {
                            Console.WriteLine("\nCódigo: " + refugios[i, 0]);
                            Console.WriteLine("Capacidad: " + refugios[i, 1]);
                            Console.WriteLine("Suministros: " + refugios[i, 2]);

                            if (refugios[i, 4] == 1)
                            {
                                Console.WriteLine("Ocupado: Sí");
                            }
                            else
                            {
                                Console.WriteLine("Ocupado: No");
                            }

                            Console.WriteLine("----------------------------");

                            encontrado = true;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No hay refugios registrados en esa zona.");
                    }
                }
            }
        }
    }

    static void PromedioPorZona(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            Console.WriteLine("==== PROMEDIO DE CAPACIDAD POR ZONA ====");

            for (int zonaActual = 1; zonaActual <= 4; zonaActual++)
            {
                int suma = 0;
                int cantidad = 0;

                for (int i = 0; i < cantidadRefugios; i++)
                {
                    if (refugios[i, 3] == zonaActual)
                    {
                        suma = suma + refugios[i, 1];
                        cantidad++;
                    }
                }

                if (cantidad > 0)
                {
                    double promedio = (double)suma / cantidad;

                    if (zonaActual == 1)
                    {
                        Console.WriteLine("NORTE (Congreso): " + promedio);
                    }
                    else if (zonaActual == 2)
                    {
                        Console.WriteLine("SUR (Constitución): " + promedio);
                    }
                    else if (zonaActual == 3)
                    {
                        Console.WriteLine("OESTE (Flores): " + promedio);
                    }
                    else
                    {
                        Console.WriteLine("CENTRO (Microcentro): " + promedio);
                    }
                }
                else
                {
                    if (zonaActual == 1)
                    {
                        Console.WriteLine("NORTE (Congreso): No hay refugios.");
                    }
                    else if (zonaActual == 2)
                    {
                        Console.WriteLine("SUR (Constitución): No hay refugios.");
                    }
                    else if (zonaActual == 3)
                    {
                        Console.WriteLine("OESTE (Flores): No hay refugios.");
                    }
                    else
                    {
                        Console.WriteLine("CENTRO (Microcentro): No hay refugios.");
                    }
                }
            }
        }
    }

    static void MasSuministros(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            int mayor = refugios[0, 2];

            
            for (int i = 1; i < cantidadRefugios; i++)
            {
                if (refugios[i, 2] > mayor)
                {
                    mayor = refugios[i, 2];
                }
            }

            int cantidadMaximos = 0;

            
            for (int i = 0; i < cantidadRefugios; i++)
            {
                if (refugios[i, 2] == mayor)
                {
                    cantidadMaximos++;
                }
            }

            if (cantidadMaximos > 1)
            {
                Console.WriteLine("Hay varios refugios con la misma cantidad máxima de suministros.");
            }

            Console.WriteLine("Mayor cantidad de suministros: " + mayor);
            
            for (int i = 0; i < cantidadRefugios; i++)
            {
                if (refugios[i, 2] == mayor)
                {
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);
                    Console.WriteLine("----------------------------");
                }
            }
        }
    }

    static void MostrarOcupados(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            bool hayOcupados = false;

            Console.WriteLine("==== REFUGIOS OCUPADOS ====");

            for (int i = 0; i < cantidadRefugios; i++)
            {
                if (refugios[i, 4] == 1)
                {
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);

                    if (refugios[i, 3] == 1)
                    {
                        Console.WriteLine("Zona: NORTE (Congreso)");
                    }
                    else if (refugios[i, 3] == 2)
                    {
                        Console.WriteLine("Zona: SUR (Constitución)");
                    }
                    else if (refugios[i, 3] == 3)
                    {
                        Console.WriteLine("Zona: OESTE (Flores)");
                    }
                    else
                    {
                        Console.WriteLine("Zona: CENTRO (Microcentro)");
                    }

                    Console.WriteLine("----------------------------");

                    hayOcupados = true;
                }
            }

            if (!hayOcupados)
            {
                Console.WriteLine("No hay refugios ocupados.");
            }
        }
    }

    static void OcuparRefugio(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            bool hayLibres = false;

            Console.WriteLine("==== REFUGIOS DISPONIBLES ====");

            for (int i = 0; i < cantidadRefugios; i++)
            {
                if (refugios[i, 4] == 0)
                {
                    Console.WriteLine("Código: " + refugios[i, 0]);
                    Console.WriteLine("Capacidad: " + refugios[i, 1]);
                    Console.WriteLine("Suministros: " + refugios[i, 2]);
                    Console.WriteLine("----------------------------");

                    hayLibres = true;
                }
            }

            if (!hayLibres)
            {
                Console.WriteLine("No hay refugios libres.");
            }
            else
            {
                Console.Write("Ingrese el código del refugio que desea ocupar: ");
                int codigoBuscar = int.Parse(Console.ReadLine());

                bool encontrado = false;

                for (int i = 0; i < cantidadRefugios; i++)
                {
                    if (refugios[i, 0] == codigoBuscar)
                    {
                        encontrado = true;

                        if (refugios[i, 4] == 1)
                        {
                            Console.WriteLine("No somos Okupas, esto ya está ocupado");
                        }
                        else
                        {
                            refugios[i, 4] = 1;
                            Console.WriteLine("Refugio ocupado correctamente.");
                        }
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No existe un refugio con ese código.");
                }
            }
        }
    }

    static void MostrarRefugios(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios == 0)
        {
            Console.WriteLine("No hay refugios registrados.");
        }
        else
        {
            Console.WriteLine("==== TODOS LOS REFUGIOS ====");

            for (int i = 0; i < cantidadRefugios; i++)
            {
                Console.WriteLine("\nRefugio " + (i + 1));
                Console.WriteLine("Código: " + refugios[i, 0]);
                Console.WriteLine("Capacidad máxima: " + refugios[i, 1]);
                Console.WriteLine("Suministros: " + refugios[i, 2]);

                if (refugios[i, 3] == 1)
                {
                    Console.WriteLine("Zona: NORTE (Congreso)");
                }
                else if (refugios[i, 3] == 2)
                {
                    Console.WriteLine("Zona: SUR (Constitución)");
                }
                else if (refugios[i, 3] == 3)
                {
                    Console.WriteLine("Zona: OESTE (Flores)");
                }
                else
                {
                    Console.WriteLine("Zona: CENTRO (Microcentro)");
                }

                if (refugios[i, 4] == 1)
                {
                    Console.WriteLine("Ocupado: Sí");
                }
                else
                {
                    Console.WriteLine("Ocupado: No");
                }

                Console.WriteLine("----------------------------");
            }
        }
    }

    static int AgregarRefugio(int[,] refugios, int cantidadRefugios)
    {
        if (cantidadRefugios >= 20)
        {
            Console.WriteLine("No hay refugios... ¡Vamos a morir!.");
        }
        else
        {
            int codigo;
            int capacidad;
            int suministros;
            int zona;
            int ocupado;

            bool valido;

            
            valido = false;

            while (!valido)
            {
                Console.Write("Ingrese el código del refugio: ");
                codigo = int.Parse(Console.ReadLine());

                bool repetido = false;

                for (int i = 0; i < cantidadRefugios; i++)
                {
                    if (refugios[i, 0] == codigo)
                    {
                        repetido = true;
                    }
                }

                if (repetido)
                {
                    Console.WriteLine("Ese código ya existe. Ingrese otro.");
                }
                else
                {
                    valido = true;
                    refugios[cantidadRefugios, 0] = codigo;
                }
            }

            
            valido = false;

            while (!valido)
            {
                Console.Write("Ingrese la capacidad máxima: ");
                capacidad = int.Parse(Console.ReadLine());

                if (capacidad <= 0)
                {
                    Console.WriteLine("No se puede sobrevivir debiendo...");
                }
                else
                {
                    valido = true;
                    refugios[cantidadRefugios, 1] = capacidad;
                }
            }

            
            valido = false;

            while (!valido)
            {
                Console.Write("Ingrese los suministros disponibles: ");
                suministros = int.Parse(Console.ReadLine());

                if (suministros <= 0)
                {
                    Console.WriteLine("No se puede sobrevivir debiendo...");
                }
                else
                {
                    valido = true;
                    refugios[cantidadRefugios, 2] = suministros;
                }
            }

           
            valido = false;

            while (!valido)
            {
                Console.WriteLine("1 = NORTE (Congreso)");
                Console.WriteLine("2 = SUR (Constitución)");
                Console.WriteLine("3 = OESTE (Flores)");
                Console.WriteLine("4 = CENTRO (Microcentro)");
                Console.Write("Ingrese la zona: ");

                zona = int.Parse(Console.ReadLine());

                if (zona < 1 || zona > 4)
                {
                    Console.WriteLine("Zona inválida, esa parte ya está perdida");
                }
                else
                {
                    valido = true;
                    refugios[cantidadRefugios, 3] = zona;
                }
            }

   
            valido = false;

            while (!valido)
            {
                Console.Write("¿Está ocupado? (1 = Sí / 0 = No): ");
                ocupado = int.Parse(Console.ReadLine());

                if (ocupado != 0 && ocupado != 1)
                {
                    Console.WriteLine("Ingrese solamente 1 o 0.");
                }
                else
                {
                    valido = true;
                    refugios[cantidadRefugios, 4] = ocupado;
                }
            }

            cantidadRefugios++;

            Console.WriteLine("Refugio agregado correctamente.");
        }

        return cantidadRefugios;
    }
}


