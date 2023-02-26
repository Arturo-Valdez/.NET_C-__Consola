using System;
namespace SortTheNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CapturaValores();
        }

        static void CapturaValores()
        {
            int orden = 0, valores;
            int[] arrayNumeros;
            Random aleatorio = new Random();
            

            Console.WriteLine("Cuanto numeros te gustaria ordenar: ");
            valores = int.Parse(Console.ReadLine());
            arrayNumeros = new int[valores];

            //Captura de Valores
            for (int i = 0; i < valores; i++)
            {
                try
                {
                    Console.WriteLine($"Dame el valor a ordenado {i}: ");
                    arrayNumeros[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception )//Si el valor es incorrecto agregara un numero aleatorio
                {
                    int valorAleatorio = aleatorio.Next(1, 100);
                    arrayNumeros[i] = valorAleatorio;
                    Console.WriteLine($"El valor agregado no es el correcto, el valor sera un numero aleatorio {valorAleatorio}");
                    Console.WriteLine();
                }
            }

            //Ordenado de Valores de Menor a mator
            for (int j = 0; j < valores; j++)
            {
                for (int k = 0; k < valores; k++)
                {
                    //menor a mayor
                    if (arrayNumeros[j] < arrayNumeros[k])
                    {
                        orden = arrayNumeros[j];
                        arrayNumeros[j] = arrayNumeros[k];
                        arrayNumeros[k] = orden;
                    }
                }
            }

            Console.WriteLine("###########################################");
            Console.WriteLine("MENOR A MAYOR");

            for (int q = 0; q < valores; q++)
            {
                
                Console.Write($" - {arrayNumeros[q]}");
               
            }
            Console.WriteLine();


            //REVIERTE LOS NUMEROS ORDENADOS AL CONTRARIO
            Array.Reverse(arrayNumeros);

            Console.WriteLine("###########################################");
            Console.WriteLine("MAYOR A MENOR");
            for (int q = 0; q < valores; q++)
            {

                Console.Write($" - {arrayNumeros[q]}");
            }
        }
    }
}