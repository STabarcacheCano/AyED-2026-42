using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main()
        {
           
            int[] numeros = { 4, 7, 12, 9, 5, 20, 3, 15 , 50 , 0 , 34 , 52 , 6 , 22 , 67 };

            int contadorPares = 0;
            int contadorImpares = 0;

           
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }

           
            int[] numerosPares = new int[contadorPares];
            int[] numerosImpares = new int[contadorImpares];

            int indicePares = 0;
            int indiceImpares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    numerosPares[indicePares] = numeros[i];
                    indicePares++; 
                
                }
                else
                {
                    numerosImpares[indiceImpares] = numeros[i];
                    indiceImpares++; 

                }
            }

            Console.WriteLine(" NÚMEROS PARES ");
            for (int i = 0; i < numerosPares.Length; i++)
            {
                Console.Write(numerosPares[i] + " ");
            }
        
            Console.WriteLine("\n\n NÚMEROS IMPARES ");
            for (int i = 0; i < numerosImpares.Length; i++)
            {
                Console.Write(numerosImpares[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
