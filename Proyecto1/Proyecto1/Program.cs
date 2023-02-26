using System;
namespace Proyecto1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("INICIO DE TAREA");
            SeleccionTarea();
            
        }


        //SELECCION DE TAREAS
        static void SeleccionTarea()
        {
            
            Console.Clear();
            Console.WriteLine("Par e impar ==> a");
            Console.WriteLine("Calculadora ==> b");
            Console.Write($"Que tarea te gustaria realizar?: ");
            string select = Console.ReadLine();

            if (select == "a")
            {
                Console.Clear();
                parImpar();
            }
            else if (select == "b")
            {
                Console.Clear();
                Calculadora();

            }
            else if (select != "a" || select != "b" )
            {
                Console.WriteLine("Favor de seleccionar las tareas disponibles");
                SeleccionTarea();
                Console.Clear();
            }
        }

        static void finalContinuar()
        {
            
            Console.WriteLine("Ir a menu principal ==> i");
            Console.WriteLine("Finalizar ==> x");
            Console.Write("Selecciona una accion: ");
            string select = Console.ReadLine();
            if(select == "i")
            {
                SeleccionTarea();
            }
            else if(select == "x") 
            {
                Console.WriteLine("Hasta la proxima :)");
            }

            
        }



        //METODO VOID PAR IMPAR
         static void parImpar()
        {
            //AGREGAR DATOS DESDE CONSOLA
            Console.Write("Dame que rango que te gustaria saber: ");
            int a = int.Parse(Console.ReadLine());
            //CICLO
            for (int i = 1; i <= a; i++)
            {

                //CONDICIONAL DE PAR IMPAR
                if (i % 2 == 0)
                {
                    Console.WriteLine($"PAR: {i}");
                }
                else
                {
                    Console.WriteLine($"IMPAR: {i}");
                }
                

            }
            finalContinuar();
        }

        //METODO PARA CALCULAR
        static void Calculadora()
        {
            
            Console.WriteLine("Suma ==> a");
            Console.WriteLine("Resta ==> b");
            Console.WriteLine("Multiplicacion ==> c");
            Console.WriteLine("Divicion ==> d");

            Console.WriteLine("Dame una tarea: ");
            string select = Console.ReadLine();
            Console.Write("Dame el valor del primer numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Dame el valor del primer numero: ");
            int num2 = int.Parse(Console.ReadLine());

            
            


            if (select == "a")
            {
                Console.WriteLine("suma = " +suma(num1, num2));
            }
            else if (select == "b")
            {
                Console.WriteLine("resta = "+resta(num1, num2));
            }
            else if (select == "c")
            {
                Console.WriteLine("multiplkicacion = "+mult(num1, num2));
            }
            else if (select == "d")
            {
                Console.WriteLine("divicion = "+divicion(num1, num2));
            }
            finalContinuar();



        }

        static int suma(int num1, int num2)
        {
            return num1 + num2;
        }

        static int resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static double mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static double divicion(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}