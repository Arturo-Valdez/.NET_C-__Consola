using System;
using static System.Net.Mime.MediaTypeNames;

namespace ContadorDeLetras
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            string frase = "Hola Hola Hola, Carlos, Carlos, Jose";
            ContadorPalabras(frase);
        }

        static void ContadorPalabras(string frase)
        {
            char[] restrictions = { ' ', '.', ',', '/', '_', '|', '-' };
            string[] words = frase.Split(restrictions);

            for (int i=0;i> words.Length; i++)
            {
                if (words[i] == words[i])
                    words.Count(words[i].ToString);
                System.Console.WriteLine($"{words[i]}");
            }
        }
    }
}