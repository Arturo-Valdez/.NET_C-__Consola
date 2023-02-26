using System;
namespace POO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Circulo miCirculo = new Circulo();//Creacion de objeto tipo circulo e Inicializarlo, variable objeto tipo circulo
            //Console.WriteLine( miCirculo.CalculoArea(5));

            //Circulo miCirculo2 = new Circulo();
            //Console.WriteLine(miCirculo2.CalculoArea(9));

            ConversorEuroDolar conversor = new ConversorEuroDolar();
            //Console.WriteLine(conversor.Convierte(50));
            conversor.CambiodeValorEuro(5);
            Console.WriteLine(conversor.Convierte(5));

        }
    }
    class Circulo //Clase Circulo
    {
        private const double pi = 3.1416; //Propiedad de la clase circulo.

        public double CalculoArea(int radio)//Metodo de clase, Comportamientos
        {
            return pi * (radio * radio);
        }
    }



    class ConversorEuroDolar
    {
        //Encapsulamiento
        private double euro = 1;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiodeValorEuro(double nuevoValor) 
        {
            if(nuevoValor < 0)
            {
                nuevoValor= euro;
            }
            else
            {
                euro = nuevoValor;
            }
        }
    }
}