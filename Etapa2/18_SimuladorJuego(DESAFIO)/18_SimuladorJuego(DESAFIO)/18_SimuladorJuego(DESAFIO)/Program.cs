using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego_DESAFIO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias_sobrevividos = 1;
            int vida = 10;
            int hambre = 10;
            int comida_cruda = 0;
            int comida_cocida = 0;
            bool refugio = false;
            bool fogata = false;
            bool exploró_isla = false;
            bool salir = false;
            int material = 0;

            int condiciones = 0;

            while (condiciones == 0)
            {
                Console.WriteLine("------------ Supervivencia en la Isla ------------");
                Console.WriteLine("");
                Console.WriteLine("Su situacón actual es:");
                Console.WriteLine("Tienes " + vida + " puntos de vida.");
                Console.WriteLine("Tenes " + hambre + " puntos de hambre.");
                Console.WriteLine("Días en la Isla " + dias_sobrevividos);
                Console.WriteLine("Tenes " + comida_cruda + " de comida cruda");
                Console.WriteLine("Tenes " + comida_cocida + " de comida cocida");
                Console.WriteLine("Tenes " + material + " de material.");

                if (refugio == true)
                {
                    Console.WriteLine("Tenes refugio.");
                }
                else
                {
                    Console.WriteLine("No tenes refugio.");
                }
                if (fogata == true)
                {
                    Console.WriteLine("Tenes fogata.");
                }
                else
                {
                    Console.WriteLine("No tenes fogata.");
                }

                Console.WriteLine("");
                Console.WriteLine("Tenes estas opciones:");
                Console.WriteLine("");
                Console.WriteLine("1) Buscar Comida");
                Console.WriteLine("2) Explorar la Isla");
                Console.WriteLine("3) Construir refugio (se necesita 6 de materiales)");
                Console.WriteLine("4) Construir fogata (se necesita 2 de materiales)");
                Console.WriteLine("5) Cocinar comida cruda");
                Console.WriteLine("6) Comer comida cocida");
                Console.WriteLine("7) Descansar");
                Console.WriteLine("8) Salir");
                Console.WriteLine("");
                Console.Write("Opción elegida: ");
                int opción = int.Parse(Console.ReadLine());

                switch (opción)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción 1.");
                        Console.WriteLine("Buscando comida...");
                        Random provabilidad = new Random();
                        int suerte = provabilidad.Next(1, 100);
                        if (suerte <= 60)
                        {
                            Console.WriteLine("Encontraste comida");
                            comida_cruda += 2;
                            Console.WriteLine("+2 de comida");
                        }
                        else
                        {
                            Console.WriteLine("No encontraste comida");
                        }

                        vida -= 1;
                        Console.WriteLine("-1 de vida");
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción 2.");
                        Console.WriteLine("Explorando la Isla...");
                        Random provabilida = new Random();
                        int suerte_explorando = provabilida.Next(1, 100);

                        if (suerte_explorando <= 50)
                        {
                            Console.WriteLine("Encontraste algo util.");
                            Console.WriteLine("+4 de material.");
                            material += 4;

                        }
                        else if (suerte_explorando >= 71)
                        {
                            Console.WriteLine("Sufriste un accidente explorando.");
                            Console.WriteLine("-2 de vida");
                            vida -= 2;
                        }
                        else
                        {
                            Console.WriteLine("No encontraste nada.");
                            
                        }

                        exploró_isla = true;

                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción de construir refugio.");
                        if ( refugio != true)
                        {
                            if (material >= 6)
                            {
                                Console.WriteLine("Construyendo refugio...");
                                Console.WriteLine("Refugio construido.");
                                refugio = true;
                                material -= 6;
                            }
                            else
                            {
                                Console.WriteLine("No tenés los materiales suficientes, elegir otra opción.");
                                dias_sobrevividos -= 1;
                                hambre += 2;
                                if (hambre <= 0)
                                {
                                    vida += 2;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya tenes refugio, elegir otra opción.");
                            dias_sobrevividos -= 1;
                            hambre += 2;
                            if (hambre <= 0)
                            {
                                vida += 2;
                            }
                        }

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción de construir fogata.");
                        if (fogata != true)
                        {
                            if ((material >= 2) && (exploró_isla == true))
                            {
                                Console.WriteLine("Construyendo fogata...");
                                Console.WriteLine("Fogata construida.");
                                fogata = true;
                                material -= 2;
                            }
                            else
                            {
                                Console.WriteLine("No tenés los materiales suficientes, elegir otra opción.");
                                dias_sobrevividos -= 1;
                                hambre += 2;
                                if (hambre <= 0)
                                {
                                    vida += 2;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya tenes fogata, elegir otra opción.");
                            dias_sobrevividos -= 1;
                            hambre += 2;
                            if (hambre <= 0)
                            {
                                vida += 2;
                            }
                        }

                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción de cocinar comida.");
                        if (comida_cruda > 0 && fogata == true)
                        {
                            Console.WriteLine("Cocinando comida...");
                            comida_cocida += comida_cruda;
                            comida_cruda -= comida_cruda;
                        }
                        else if (fogata == false)
                        {
                            Console.WriteLine("No tiene fogata para cocinar, elegir otra opción.");
                            dias_sobrevividos -= 1;
                            hambre += 2;
                            if (hambre <= 0)
                            {
                                vida += 2;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene comida, elegir otra opción.");
                            dias_sobrevividos -= 1;
                            hambre += 2;
                            if (hambre <= 0)
                            {
                                vida += 2;
                            }
                        }

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción de comer comida.");

                        if (comida_cocida > 0)
                        {
                            Console.WriteLine("Comiendo...");
                            Console.WriteLine("Hambre = 10");
                            int falta_de_comida = 10 - hambre;
                            if (falta_de_comida % 4 == 0)
                            {
                                if ((falta_de_comida / 4) > comida_cocida)
                                {
                                    hambre += comida_cocida * 4;
                                    comida_cocida = 0;
                                }
                                else
                                {
                                    hambre += falta_de_comida;
                                    comida_cocida -= falta_de_comida / 4;
                                }
                            }
                            else
                            {
                                hambre += falta_de_comida + 4;
                                comida_cocida -= (falta_de_comida / 4) + 1;
                                

                            }

                           
                        }
                        else
                        {
                            Console.WriteLine("No tenes comida cocida, elegir otra opción");
                            dias_sobrevividos -= 1;
                            hambre += 2;
                            if (hambre <= 0)
                            {
                                vida += 2;
                            }
                        }

                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Se selecciono la opción de descansar.");
                        Console.WriteLine("Descansando...");
                        if (refugio == true)
                        {
                            vida += 3;
                        }
                        else
                        {
                            vida++;
                        }

                        if (vida > 10)
                        {
                            int calculo_de_10 = vida - 10;
                            vida -= calculo_de_10;
                        }

                        break;

                    case 8:

                        salir = true;
                        Console.WriteLine("");
                        break;

                        
                }
                dias_sobrevividos++;
                hambre -= 2;
                if (hambre <= 0)
                {
                    vida -= 2;
                }


                if (hambre < 0)
                {
                    int calculo_de_0 = hambre * -1;
                    hambre += calculo_de_0;
                }

                if ( hambre > 10)
                {
                    int calculo_de_10 = hambre - 10;
                    hambre -= calculo_de_10;
                }

                if (salir == true || dias_sobrevividos > 10 || vida <= 0)
                {
                    condiciones += 2;
                }
            }

            Console.Clear();

            if (dias_sobrevividos >= 10)
            {
                Console.WriteLine("Juego terminado, sobreviviste el maximó de días (10).");
            }
            else if (vida <= 0)
            {
                Console.WriteLine("Juego terminado, te quedaste sin vida. Dias sobrevividos: " + (dias_sobrevividos -1));    
            }
            else
            {
                Console.WriteLine("Saliste del Juego");
            }

            Console.ReadKey();

        }
    }
}
