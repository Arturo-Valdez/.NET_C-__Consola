using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace PooUsoCoches
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Coche coche1 = new Coche();//Crea objeto / instancia de tipo coche // dar un extado inicial
            //a nuestro coche

            //LLAMA PRIMER CONSTRUCTOR
            Coche coche2 = new Coche();

            //Console.WriteLine(coche1.getInfoCoche());

            //Coche coche3 = new Coche(4125.15, 56525.45);
            //Console.WriteLine(coche3.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            coche2.setExtras(true, "Cuero");
            Console.WriteLine( coche2.getExtras());
        }


    }

    class Coche//clase
    {
        //Constructor
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 20.18;

        }

        public Coche(double largo, double ancho)
        {
            ruedas = 4;
            //this.largo es el valor que se encuentra por fuera seria null, lo transforma a valor
            //generado fuera de la creacion de objeto
            this.largo = largo;
            this.ancho = ancho;
        }

        
        public string getInfoCoche() //PERMITE VISUALIZAR EL VALOR DE VARIABLE RUEDAS y se
                                     //requiere "get(nombre)"
        {
            return $"Informacion del coche:\nRuedas: {ruedas} - - Largo: {largo} - - Ancho: {ancho}";
        }


        //setters requiere getter se utiliza set(nombrefuncion) 
        //SETTER captura datos
        public void setExtras(bool paramClimatizador, string paramTapiceria)
        {
            climatizador = paramClimatizador;

             
            tapiceria = paramTapiceria;
        }

        //GETTER muestra datos
        public string getExtras()
        {
            if (climatizador == true)
            {
                return $"Extras del coche: \nTapiceria: {tapiceria} - - Cuenta con climatizador";
            }
            else
            {
                return  $"Extras del coche: \nTapiceria: {tapiceria} - - No cuenta climatizadodor";
            }

        }
       

        //Variables privadas
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}