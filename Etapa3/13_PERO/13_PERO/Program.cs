using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _13_PERO
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] misiones = new int[30, 5];


            int cantidad_misiones = 0;
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("==== MENÚ DEL P.E.R.O. ====");
                Console.WriteLine("1. Registrar nueva misión");
                Console.WriteLine("2. Ver todas las misiones");
                Console.WriteLine("3. Cambiar estado de una misión");
                Console.WriteLine("4. Listar misiones en curso");
                Console.WriteLine("5. Misión con más objetos a extraer");
                Console.WriteLine("6. Promedio de peligro por mapa");
                Console.WriteLine("7. Filtrar por mapa");
                Console.WriteLine("8. Salir");

                Console.Write("Opción: ");
                int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion)
                {
                    case 1:
                        

                        if (cantidad_misiones < 30)
                        {
                            bool valido = false;
                            int mapa = 0;
                            int peligro = 0;

                            Console.WriteLine("\n=== REGISTRAR NUEVA MISIÓN ===");

                            
                            while (valido == false)
                            {
                                Console.WriteLine("Mapas disponibles:");
                                Console.WriteLine("1. Hogwarts");
                                Console.WriteLine("2. La Casa del Viejo");
                                Console.WriteLine("3. El Laboratorio");
                                Console.Write("Ingrese el mapa: ");

                                int.TryParse(Console.ReadLine(), out mapa);

                                if (mapa >= 1 && mapa <= 3)
                                {
                                    valido = true;
                                }
                                else
                                {
                                    Console.WriteLine("Ese mapa no es de este juegazo.");
                                }
                            }

                            
                            valido = false;

                            while (valido == false)
                            {
                                Console.Write("Ingrese el nivel de peligro (1 a 5): ");
                                int.TryParse(Console.ReadLine(), out peligro);

                                if (peligro >= 1 && peligro <= 5)
                                {
                                    valido = true;
                                }
                                else
                                {
                                    Console.WriteLine("Este nivel es demasiado PELIGROSO...");
                                }
                            }

                            
                            misiones[cantidad_misiones, 0] = cantidad_misiones + 1;
                            misiones[cantidad_misiones, 1] = mapa;
                            misiones[cantidad_misiones, 2] = rand.Next(1, 71);
                            misiones[cantidad_misiones, 3] = peligro;
                            misiones[cantidad_misiones, 4] = 0;

                            Console.WriteLine("\nMisión registrada correctamente.");
                            Console.WriteLine("ID: " + misiones[cantidad_misiones, 0]);
                            Console.WriteLine("Objetos a extraer: " + misiones[cantidad_misiones, 2]);

                            cantidad_misiones++;
                        }
                        else
                        {
                            Console.WriteLine("¡Demasiadas misiones!");
                        }

                        break;

                    case 2:
                        

                        Console.WriteLine("\n=== TODAS LAS MISIONES ===");

                        if (cantidad_misiones == 0)
                        {
                            Console.WriteLine("No hay misiones registradas.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidad_misiones; i++)
                            {
                                Console.WriteLine("\nID: " + misiones[i, 0]);

                                Console.WriteLine("Mapa: " + misiones[i, 1]);
                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                                if (misiones[i, 4] == 0)
                                {
                                    Console.WriteLine("Estado: Pendiente");
                                }
                                else if (misiones[i, 4] == 1)
                                {
                                    Console.WriteLine("Estado: En Curso");
                                }
                                else
                                {
                                    Console.WriteLine("Estado: Finalizado");
                                }
                            }
                        }

                        break;

                    case 3:
                       

                        Console.WriteLine("\n=== CAMBIAR ESTADO ===");

                        if (cantidad_misiones == 0)
                        {
                            Console.WriteLine("No hay misiones registradas.");
                        }
                        else
                        {
                            int id_buscar;
                            bool encontrado = false;

                            Console.Write("Ingrese el ID de la misión: ");
                            int.TryParse(Console.ReadLine(), out id_buscar);

                            for (int i = 0; i < cantidad_misiones; i++)
                            {
                                if (misiones[i, 0] == id_buscar)
                                {
                                    encontrado = true;

                                    if (misiones[i, 4] == 0)
                                    {
                                        misiones[i, 4] = 1;
                                        Console.WriteLine("La misión ahora está En Curso.");
                                    }
                                    else if (misiones[i, 4] == 1)
                                    {
                                        misiones[i, 4] = 2;
                                        Console.WriteLine("La misión ahora está Finalizada.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("La misión ya está Finalizada.");
                                    }
                                }
                            }

                            if (encontrado == false)
                            {
                                Console.WriteLine("No existe una misión con ese ID.");
                            }
                        }

                        break;

                    case 4:
                    

                        Console.WriteLine("\n=== MISIONES EN CURSO ===");

                        bool hay_misiones = false;

                        for (int i = 0; i < cantidad_misiones; i++)
                        {
                            if (misiones[i, 4] == 1)
                            {
                                hay_misiones = true;

                                Console.WriteLine("\nID: " + misiones[i, 0]);
                                Console.WriteLine("Mapa: " + misiones[i, 1]);
                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);
                                Console.WriteLine("Estado: En Curso");
                            }
                        }

                        if (hay_misiones == false)
                        {
                            Console.WriteLine("No hay misiones en curso.");
                        }

                        break;

                    case 5:
                      

                        Console.WriteLine("\n=== MISIÓN CARGADITA ===");

                        if (cantidad_misiones == 0)
                        {
                            Console.WriteLine("No hay misiones registradas.");
                        }
                        else
                        {
                            int mayor = misiones[0, 2];

                            for (int i = 1; i < cantidad_misiones; i++)
                            {
                                if (misiones[i, 2] > mayor)
                                {
                                    mayor = misiones[i, 2];
                                }
                            }

                            for (int i = 0; i < cantidad_misiones; i++)
                            {
                                if (misiones[i, 2] == mayor)
                                {
                                    Console.WriteLine("\nID: " + misiones[i, 0]);
                                    Console.WriteLine("Mapa: " + misiones[i, 1]);
                                    Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                    Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);
                                    Console.WriteLine("Estado: " + misiones[i, 4]);
                                }
                            }
                        }

                        break;

                    case 6:
                        

                        Console.WriteLine("\n=== PROMEDIO DE PELIGRO POR MAPA ===");

                        for (int mapa = 1; mapa <= 3; mapa++)
                        {
                            int suma_peligro = 0;
                            int contador = 0;

                            for (int i = 0; i < cantidad_misiones; i++)
                            {
                                if (misiones[i, 1] == mapa)
                                {
                                    suma_peligro += misiones[i, 3];
                                    contador++;
                                }
                            }

                            Console.Write("\nMapa " + mapa + ": ");

                            if (contador > 0)
                            {
                                double promedio = (double)suma_peligro / contador;

                                Console.WriteLine("Promedio de peligro: " + promedio);
                            }
                            else
                            {
                                Console.WriteLine("No hay misiones registradas.");
                            }
                        }

                        break;

                    case 7:
                      

                        Console.WriteLine("\n=== FILTRAR POR MAPA ===");

                        bool mapa_valido = false;
                        int mapa_filtro = 0;

                        while (mapa_valido == false)
                        {
                            Console.WriteLine("1. Hogwarts");
                            Console.WriteLine("2. La Casa del Viejo");
                            Console.WriteLine("3. El Laboratorio");
                            Console.Write("Ingrese el mapa: ");

                            int.TryParse(Console.ReadLine(), out mapa_filtro);

                            if (mapa_filtro >= 1 && mapa_filtro <= 3)
                            {
                                mapa_valido = true;
                            }
                            else
                            {
                                Console.WriteLine("Ese mapa no es de este juegazo.");
                            }
                        }

                        bool encontrado_mapa = false;

                        for (int i = 0; i < cantidad_misiones; i++)
                        {
                            if (misiones[i, 1] == mapa_filtro)
                            {
                                encontrado_mapa = true;

                                Console.WriteLine("\nID: " + misiones[i, 0]);
                                Console.WriteLine("Mapa: " + misiones[i, 1]);
                                Console.WriteLine("Objetos a extraer: " + misiones[i, 2]);
                                Console.WriteLine("Nivel de peligro: " + misiones[i, 3]);

                                if (misiones[i, 4] == 0)
                                {
                                    Console.WriteLine("Estado: Pendiente");
                                }
                                else if (misiones[i, 4] == 1)
                                {
                                    Console.WriteLine("Estado: En Curso");
                                }
                                else
                                {
                                    Console.WriteLine("Estado: Finalizado");
                                }
                            }
                        }

                        if (encontrado_mapa == false)
                        {
                            Console.WriteLine("No hay misiones registradas para ese mapa.");
                        }

                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Esperemos que el PERO no sea letal!");
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
        }
    }
}