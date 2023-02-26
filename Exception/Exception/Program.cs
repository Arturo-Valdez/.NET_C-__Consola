using System;
namespace Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("JUEGO ADIVINA MI NUMERO TIENES SOLO 5 INTENTOS PARA ADIVINAR");
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1,10);
            int num = 0;
            int intentos = 0; 
            
            while (valor != num)
            {
                Console.WriteLine("#########################");
                Console.WriteLine("#########################")-;
                intentos++;
                Console.WriteLine($"Intento numero {intentos}");
                Console.Write("Dame un numero: ");



                //EXCEPCIONES CON TRY CATCH
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha habido un error, se introducira 0 como valor");
                    Console.WriteLine(e.Message);
                    num = 0;
                }

                //################################################################
                //################################################################
                //CONDICIONALES DE EJERCICIO PARA ACERTAR
                if(valor == num)
                {
                    Console.WriteLine("Le has atinado");
                    Console.WriteLine("Felicidades :D");
                }
                else if(valor > num)
                {
                    Console.WriteLine("Te falto un poco mas");
                }
                else if(valor < num)
                {
                    Console.WriteLine("Te has pasado un poco");
                }
            }

           

        }
    }
}