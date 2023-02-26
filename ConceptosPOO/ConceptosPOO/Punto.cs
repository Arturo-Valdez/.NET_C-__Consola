using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    class Punto
    {
        public Punto(int x, int y) 
        {
            this.x= x;
            this.y= y;
            contador++;
        }
        public Punto() 
        { 
            this.x = 0;
            this.y = 0;
            contador++;
        }

        //UN METODO RECIBE UN OBJETO
        public double DistanciaHasta(Punto otroPunto)
        {

            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            Console.WriteLine($"otroPunto y = {otroPunto.y} otroPunto x = {otroPunto.x}");
            Console.WriteLine($"this x = {this.x} this y = {this.y}");
            Console.WriteLine($"xDif = {xDif} yDif = {yDif}");
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }

        public static int Contador() => contador;

        private int y, x;
        private static int contador = 0;
    }
}
