using System;

namespace ArraysPorParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[4];//Inicializa un  array de 4 numeros enteros
            numeros[0] = 7;
            numeros[1] = 8;
            numeros[2] = 9;
            numeros[3] = 10;

            ProcesaDatos(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

        }

        //Se trabajara con un sola clase
        static void ProcesaDatos(int[] datos)
        {
            
            //Ciclo que le suma 10 a cada valor de datos.
            for (int i=0;i<datos.Length;i++)
            {
                datos[i] += 10;
            }
        }
    }
}