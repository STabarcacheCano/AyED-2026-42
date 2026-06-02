using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {
            int opción = 0;
            int vida = 0;
            int cantidad_registrados = 0;
            int cantidad_debilitados = 0;
            int[] Pokemones = new int[6];
            int[] Debilitados = new int[6];
            while (opción != 13)
            {
                Console.Clear();
                Console.WriteLine("Centro Poké-Remedio");
                Console.WriteLine("");
                Console.WriteLine("1. Registrar un nuevo pokémon");
                Console.WriteLine("2. Mostrar la vida de todos los pokemones");
                Console.WriteLine("3. Curar un pokémon");
                Console.WriteLine("4. Dañar un pokémon");
                Console.WriteLine("5. Curar a todos los pokemones");
                Console.WriteLine("6. Mostrar pokemones debilitados");
                Console.WriteLine("7. Mostrar el pokémon con mayor vida");
                Console.WriteLine("8. Mostrar el pokémon con menor vida");
                Console.WriteLine("9. Calcular promedio de vida del equipo");
                Console.WriteLine("10. Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("");
                Console.Write("Ingresar el número de opción elegida: ");
                opción = int.Parse(Console.ReadLine());

                
                

                switch (opción)
                {
                    case 1:

                        Console.Clear();
                        if (cantidad_registrados <= 5)
                        {
                            Console.Write("Ingrese la vida del pokémon: ");
                            vida = int.Parse(Console.ReadLine());
                            while (vida > 100 || vida < 0)
                            {
                                Console.Clear();
                                Console.Write("Ingrese la vida del pokémon: ");
                                vida = int.Parse(Console.ReadLine());
                            }
                            Pokemones[cantidad_registrados] = vida;
                            Console.WriteLine("Pokémon registrado correctamente en la posición " + cantidad_registrados + ".");
                            cantidad_registrados++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("No se pueden registrar más pokemones. El centro está lleno.");
                            Console.ReadKey();
                        }
                        
    
                    break;

                    case 2:

                        Console.Clear();
                        for (int i = 0; i < cantidad_registrados; i++)
                        {
                            Console.WriteLine("Pokémon " + (i + 1) + " - Vida: " + Pokemones[i]);
                        }
                        Console.ReadKey();

                    break;

                    case 3:

                        Console.Clear();
                        Console.Write("Ingrese la posición del pokémon a curar: ");
                        int posición = int.Parse(Console.ReadLine());
                        while (posición > 5 || vida < 0)
                        {
                            Console.Clear();
                            Console.Write("Ingrese la posición del pokémon a curar: ");
                            posición = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Ingrese puntos de vida a recuperar:");
                        int curar = int.Parse(Console.ReadLine());

                        Pokemones[posición] += curar;

                        if (Pokemones[posición] > 100)
                        {
                            int demás = Pokemones[posición] - 100;
                            Pokemones[posición] -= demás;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("El pokémon fue curado.");
                        Console.WriteLine("Vida actual: " + Pokemones[posición]);
                        Console.ReadKey();

                    break;

                    case 4:

                        Console.Clear();
                        Console.Write("Ingrese la posición del pokémon atacado: ");
                        int posicion = int.Parse(Console.ReadLine());
                        while (posicion > 5 || vida < 0)
                        {
                            Console.Clear();
                            Console.Write("Ingrese la posición del pokémon a curar: ");
                            posicion = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Ingrese daño recibido: ");
                        int dañar = int.Parse(Console.ReadLine());

                        Pokemones[posicion] -= dañar;

                        if (Pokemones[posicion] < 0)
                        {
                            int sumar = Pokemones[posicion] * -1;
                            Pokemones[posicion] += sumar;
                        }

                        Console.WriteLine("");
                        Console.WriteLine("El pokémon recibió daño.");
                        Console.WriteLine("Vida actual: " + Pokemones[posicion]);
                        Console.ReadKey();

                    break;

                    case 5:

                        Console.Clear();
                        Console.Write("Ingrese puntos de curación general: ");
                        int curación = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cantidad_registrados; i++)
                        {
                            Pokemones[i] += curación;

                            if (Pokemones[i] > 100)
                            {
                                int demás = Pokemones[i] - 100;
                                Pokemones[i] -= demás;
                            }
                        }

                        Console.WriteLine("Todos los pokemones fueron curados.");
                        Console.ReadKey();

                        break;

                    case 6:

                        Console.Clear();
                        for (int i = 0; i < cantidad_registrados; i++)
                        {
                            if (Pokemones[i] == 0)
                            {
                                Debilitados[cantidad_debilitados] = i;
                                cantidad_debilitados++;
                            }
                        }

                        if (cantidad_debilitados > 0)
                        {
                            Console.WriteLine("Pokemones debilitados:");
                            for (int i = 0; i < cantidad_debilitados; i++)
                            {
                                Console.WriteLine("Pokémon en posición: " + Debilitados[i] );
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Cantidad total de debilitados: " + cantidad_debilitados);
                        }
                        else
                        {
                            Console.WriteLine("No hay pokemones debilitados.");
                        }
                        cantidad_debilitados = 0;
                        Console.ReadKey();

                        break;

                    case 7:

                        Console.Clear();
                        int pos_mayor = 0;
                        int mayor = Pokemones[pos_mayor];
                        for (int i = 1; i < cantidad_registrados; i++)
                        {
                            if (Pokemones[i] > mayor)
                            {
                                mayor = Pokemones[i];
                                pos_mayor = i;
                            }
                        }
                        Console.WriteLine("El pokémon con mayor vida está en la posición "+ pos_mayor + ".");
                        Console.WriteLine("Vida: " + mayor);
                        Console.ReadKey();

                        break;

                    case 8:

                        Console.Clear();
                        int pos_menor = 0;
                        int menor = Pokemones[pos_menor];
                        for (int i = 1; i < cantidad_registrados; i++)
                        {
                            if (Pokemones[i] < menor)
                            {
                                menor = Pokemones[i];
                                pos_menor = i;
                            }
                        }
                        Console.WriteLine("El pokémon con menor vida está en la posición " + pos_menor + ".");
                        Console.WriteLine("Vida: " + menor);
                        Console.ReadKey();

                        break;

                    case 9:

                        Console.Clear();
                        int suma = 0;
                        for (int i = 1; i < cantidad_registrados; i++)
                        {
                            suma += Pokemones[i];
                        }
                        int promedio = suma / cantidad_registrados;

                        if (promedio >= 70)
                        {
                            Console.WriteLine("El equipo está en buen estado.");
                        }
                        else if (promedio >=31 && promedio <= 69)
                        {
                            Console.WriteLine("El equipo necesita curación.");
                        }
                        else
                        {
                            Console.WriteLine("El equipo está en peligro.");
                        }

                        promedio = 0;
                        Console.ReadKey();

                        break;

                    case 10:

                        Console.Clear();
                        Array.Sort(Pokemones);

                        Console.Clear();
                        Console.WriteLine("Vidas ordenadas de menor a mayor: ");
                        foreach (int vidas in Pokemones)
                        {
                            Console.WriteLine(vidas);
                        }

                        Console.ReadKey();
                        break;
                }
            }
           
        }
    }
}
