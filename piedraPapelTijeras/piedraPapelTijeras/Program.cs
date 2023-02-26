using System;

namespace piedraPapelTijeras
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int rango = aleatorio.Next(0, 4);
            int bot;
            int user;
            Console.WriteLine("PIERDA  ==> 1");
            Console.WriteLine("PAPEL   ==> 2");
            Console.WriteLine("TIJERAS ==> 3");
            

            for (int i = 1; i<= 5; i++)
            {
                
                Console.Write("Dame un numero para jugar: ");
                int Jugador = int.Parse(Console.ReadLine());

                if (rango == 1 && Jugador == 2)
                {
                    Console.WriteLine("bot PIEDRA, contra PAPEL");
                    Console.WriteLine("Felicidades le ganaste al bot!!");
                }
                else if (rango == 1 && Jugador == 3)
                {
                    Console.WriteLine("bot PIEDRA, contra TIJERAS");
                    Console.WriteLine("Que mal perdiste");
                }
                else if (rango == 1 && Jugador == 1)
                {
                    Console.WriteLine("bot PIEDRA, contra PIEDRA");
                    Console.WriteLine("Iguales!!!");
                }
                else if (rango == 2 && Jugador == 1)
                {
                    Console.WriteLine("bot PAPEL, contra PIEDRA");
                    Console.WriteLine("Que mal perdiste");
                }
                else if (rango == 2 && Jugador == 2)
                {
                    Console.WriteLine("bot PAPEL, contra PAPEL");
                    Console.WriteLine("Iguales!!!");
                }
                else if (rango == 2 && Jugador == 3)
                {
                    Console.WriteLine("bot PAPEL, contra TIJERAS");
                    Console.WriteLine("Felicidades le ganaste al bot!!");
                }
                else if (rango == 3 && Jugador == 1)
                {
                    Console.WriteLine("bot TIJERAS, contra PIEDRA");
                    Console.WriteLine("Felicidades le ganaste al bot!!");
                }
                else if (rango == 3 && Jugador == 2)
                {
                    Console.WriteLine("bot TIJERAS, contra PAPEL");
                    Console.WriteLine("Que mal perdiste");
                }
                else if (rango == 3 && Jugador == 3)
                {
                    Console.WriteLine("Bot elijio TIJERAS, contra TIJERAS");
                    Console.WriteLine("Iguales!!!");
                }
                Console.Clear();
            }
            
            



            
        }
    }
}