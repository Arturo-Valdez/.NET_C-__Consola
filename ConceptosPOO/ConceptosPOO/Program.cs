using System;
namespace ConceptosPOO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //realizarTarea();

            //Variables anonymas tipo array
            //Solo pueden contener campos publicos
            //Todos los campos deben estar indicados
            //Los campos no pueden ser static
            //No se pueden definir metodos
            var miVariable = new { Nombre = "Juan", Edad = 22 };
            Console.WriteLine($"{miVariable.Nombre} {miVariable.Edad}");

            var miSegunda = new { Nombre = "Carlos", Edad = 26};
            Console.WriteLine($"{miSegunda.Nombre} {miSegunda.Edad}");

            miVariable = miSegunda;
            Console.WriteLine($"{miVariable.Nombre} {miVariable.Edad}");
        }
        static void realizarTarea()
        {
            Punto origen = new Punto(12,8);
            Punto destino = new Punto();
            
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Numero de objetos creados: {Punto.Contador()}");
        }
    }
}