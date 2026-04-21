using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string contraseñaGuardada = "politesforever";
            string contraseñaUsuario;

            do
            {
                Console.Write("Introduce la contraseña: ");
                contraseñaUsuario = Console.ReadLine();

                if (!contraseñaGuardada.Equals(contraseñaUsuario, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contraseña incorrecta, intenta de nuevo.");
                }

            } while (!contraseñaGuardada.Equals(contraseñaUsuario, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Contraseña correcta. Acceso permitido.");
            Console.ReadKey();
        }
        }
    }
