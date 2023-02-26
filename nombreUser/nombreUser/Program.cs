using System;
namespace nombreUser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            user UUser = new user(1,"Santiago", "Alto", 10.5);
            user User = new user();
            Console.WriteLine(user.Contador());
            
        }
    }
     class user
    {
        public user()
        {
            Console.WriteLine("Datos no resividos");
            contador++;
        }
        public user (int id, string name, string level, double califi) 
        {
            Console.WriteLine($"Nombre = {name}, Nivel = {level}, Calificacion = {califi}");
            contador++;
        }
        public static int Contador() => contador;

        private static int contador = 0;
    }
}