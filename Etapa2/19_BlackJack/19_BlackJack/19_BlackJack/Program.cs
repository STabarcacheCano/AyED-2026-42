using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntaje_del_jugador = 0;
            int puntaje_del_crupier = 0;
            int carta_obtenida = 0;
            int carta_obtenida_crupier = 0;
            int partidas_ganadas = 0;
            int partidas_perdidas = 0;
            int partidas_empatadas = 0;
            int cantidad_de_cartas_pedidas_del_jugador = 0;
            int cantidad_de_cartas_pedidas_del_crupier = 0;
            bool jugador_planteado = false;
            bool crupier_planteado = false;
            bool juego_activo = true;
            bool jugar = true;

            while (jugar == true)
            {

                while ((juego_activo == true))
                {
                    Console.Clear();
                    Console.WriteLine("===== BLACKJACK SIMPLE =====");
                    Console.WriteLine("Puntaje del jugador: " + puntaje_del_jugador);
                    if ((jugador_planteado == true) || ((puntaje_del_jugador > 21) || ((crupier_planteado == true && (puntaje_del_crupier <= 21 && puntaje_del_jugador < puntaje_del_crupier)))) || (crupier_planteado == true && puntaje_del_jugador == puntaje_del_crupier))
                    {
                        Console.WriteLine("Puntaje del crupier: " + puntaje_del_crupier);
                    }
                    else
                    {
                        Console.WriteLine("Puntaje del crupier: Oculto");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("1. Pedir carta");
                    Console.WriteLine("2. Plantarse");
                    Console.WriteLine("3. Ver reglas");
                    Console.WriteLine("4. Salir");

                    Console.WriteLine("");
                    Console.Write("Elegir una opción: ");
                    int opción = int.Parse(Console.ReadLine());

                    switch (opción)
                    {
                        case 1:

                            Random valor = new Random();
                            carta_obtenida = valor.Next(1, 11);
                            puntaje_del_jugador += carta_obtenida;
                            cantidad_de_cartas_pedidas_del_jugador++;
                            break;

                        case 2:

                            while (puntaje_del_crupier < 17)
                            {
                                Random valor_crupier = new Random();
                                carta_obtenida_crupier = valor_crupier.Next(1, 11);
                                puntaje_del_crupier += carta_obtenida_crupier;
                                cantidad_de_cartas_pedidas_del_crupier++;
                            }

                            crupier_planteado = true;

                            if (jugador_planteado == false)
                            {
                                jugador_planteado = true;
                            }


                            break;

                        case 3:

                            bool respuesta = false;
                            while (respuesta == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Reglas generales del Blackjack simplificado:");
                                Console.WriteLine("_El jugador compite contra la computadora, que actúa como crupier.");
                                Console.WriteLine("_El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                                Console.WriteLine("_Cada carta suma puntos al puntaje total del jugador o del crupier.");
                                Console.WriteLine("_Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                                Console.WriteLine("_Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier.");
                                Console.WriteLine("_El crupier debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                                Console.WriteLine("_Cuando el crupier llega a 17 puntos o más, se planta.");
                                Console.WriteLine("_Si el crupier supera los 21 puntos, gana el jugador.");
                                Console.WriteLine("_Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                                Console.WriteLine("_Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                                Console.WriteLine("");
                                Console.WriteLine("1)Volver al menú.");
                                Console.WriteLine("2) Seguir leyendo.");
                                Console.WriteLine("");
                                Console.Write("Elegir opción: ");
                                int siguiente = int.Parse(Console.ReadLine());

                                if (siguiente == 1)
                                {
                                    respuesta = true;
                                }
                                else
                                {
                                    respuesta = false;
                                }
                            }

                            break;

                        case 4:

                            juego_activo = false;
                            break;

                    }
                    if (puntaje_del_jugador > 21 || jugador_planteado == true)
                    {

                        if (puntaje_del_jugador > 21 || jugador_planteado == true && puntaje_del_jugador < puntaje_del_crupier && puntaje_del_crupier <= 21)
                        {
                            Console.Clear();
                            Console.WriteLine("Ganó el crupier");
                            partidas_perdidas++;
                            juego_activo = false;

                        }
                        else if (puntaje_del_crupier > 21 || jugador_planteado == true && puntaje_del_jugador > puntaje_del_crupier && puntaje_del_jugador <= 21)
                        {
                            Console.Clear();
                            Console.WriteLine("Ganó el jugador");
                            partidas_ganadas++;
                            juego_activo = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Empataron");
                            partidas_empatadas++;
                            juego_activo = false;
                        }
                    }
                    

            }

            Console.WriteLine("Puntaje del jugador: " + puntaje_del_jugador);
            Console.WriteLine("Puntaje del crupier: " + puntaje_del_crupier);
            Console.WriteLine("");
            Console.WriteLine("Cartas pedidas por el jugador: " + cantidad_de_cartas_pedidas_del_jugador);
            Console.WriteLine("Cartas pedidas por el crupier: " + cantidad_de_cartas_pedidas_del_crupier);
            Console.WriteLine("");
            Console.WriteLine("Partidas ganadas: " + partidas_ganadas);
            Console.WriteLine("Partidas perdidas: " + partidas_perdidas);
            Console.WriteLine("Partidas empatadas: " + partidas_empatadas);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Volver a jugar");
            Console.WriteLine("1) Sí");
            Console.WriteLine("2) No");
            Console.WriteLine("");
            Console.Write("Escribir opcíon: ");
            int volver_jugar = int.Parse(Console.ReadLine());

            switch (volver_jugar)
            {
                case 1:
                    Console.Clear();
                    juego_activo = true;
                    puntaje_del_crupier = 0;
                    puntaje_del_jugador = 0;
                    cantidad_de_cartas_pedidas_del_jugador = 0;
                    cantidad_de_cartas_pedidas_del_crupier = 0;
                    jugador_planteado = false;
                    crupier_planteado = false;

                    break;

                case 2:

                    jugar = false;
                    Console.Clear();
                    Console.Write("Juego terminado.");

                    break;

            }
        } 

    
            Console.ReadKey();
        }
    }
}
