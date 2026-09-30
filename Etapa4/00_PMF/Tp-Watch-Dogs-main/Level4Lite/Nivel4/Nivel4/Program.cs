using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);
        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        string resultado = "";

        for (int i = 0; i < s.Length; i++)
        {
            char letra = s[i];

            if (letra >= 'a' && letra <= 'z')
            {
                if (letra == 'z')
                {
                    letra = 'a';
                }
                else
                {
                    letra++;
                }
            }
            else if (letra >= 'A' && letra <= 'Z')
            {
                if (letra == 'Z')
                {
                    letra = 'A';
                }
                else
                {
                    letra++;
                }
            }

            resultado += letra;
        }

        return resultado;
    }
}