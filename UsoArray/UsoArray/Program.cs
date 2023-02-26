using System;
namespace UsoArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Array implicito
            //var datos = new[] { "Juan", "Diego", "Carlos", 41}; ERROR

            var valores = new[] {40, 50 , 45, 54.54, 12.789 };

            

            //Arrays de objetos
            Empleados[] arrayEmpleados = new Empleados[3];
            Empleados carlos = new Empleados("Carlos", 40);

            arrayEmpleados[0] = new Empleados("Sara", 37);
            arrayEmpleados[1] = carlos;
            arrayEmpleados[2] = new Empleados("Miguel", 50);


            //Array de tipos o clases anonimas
            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19},
                new{Nombre = "Karla", Edad = 29},
                new{Nombre = "Karen", Edad = 39},
            };


            //for(int i = 0; i<arrayEmpleados.Length; i++)
            //{
            //    Console.WriteLine(arrayEmpleados[i].getInfo());
            //}

            foreach (var Variable in personas)
            {
                Console.WriteLine(Variable.Nombre);
            }

            for (int i = 0; i < valores.Length; i++)
            {
                for (int j = 0; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        valores[i] = valores[j];
                       
                    }
                }
            } 

        }
    }
    class Empleados
    {
        public Empleados(String nombre, int edad)
        {
            this.Nombre = nombre;
            this.edad = edad;
        }

        public String getInfo()
        {
            return $"Nombre del empleado {Nombre} Edad : {edad}";
        }

        private String Nombre;
        private int edad;
    }
}