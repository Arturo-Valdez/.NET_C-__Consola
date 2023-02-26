using System;

namespace ArraysPorParametros2
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //
            int[] arrayElementos = LeerDatos();
            Console.WriteLine("Imprimiendo desde main");


            //IMPRIME LOS VALORES DE EL ARRAY
            foreach(int i in arrayElementos) Console.WriteLine(i);


        }


        //CREADOR DE ARRAYS DE ENTEROS
        static int[] LeerDatos()
        {
            //cantidad de elementos que tendra el array
            Console.WriteLine("Cuantos elementos quieres que tenga el array?: ");
            int numElementos = int.Parse(Console.ReadLine());

            int[] datos = new int[numElementos];
            
            //pide al usuario agregar elementos que contendra el array
            for(int i =0; i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");
                int datoElemento = int.Parse(Console.ReadLine());
                datos[i] = datoElemento;
            }
            return datos;
        }
    }
}