internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Introduce numero de mes: ");
        int NumeroMes = 0;




        try
        {
             NumeroMes = int.Parse(Console.ReadLine());
            
        }
        catch(Exception e)
        {
            NumeroMes= 1;
            Console.WriteLine($"Mensaje de excepcion: {e.Message}");
            
        }

        Console.WriteLine(NombredelMes(NumeroMes));
        Console.WriteLine("AQUI CONTINUARIA LA EJECICION DEL PROGRAMA");

    }


    public static string NombredelMes(int mes)
    {
        switch(mes)
        {
            case 1:
                return "Enero";

            case 2:
                return "Febrero";

            case 3:
                return "Marzo";

            case 4:
                return "Abril";

            case 5:
                return "Mayo";

            case 6:
                return "Junio";

            case 7:
                return "Julio";

            case 8:
                return "Agosto";

            case 9:
                return "Septiembre";

            case 10:
                return "Octubre";

            case 11:
                return "Noviembre";

            case 12:
                return "Diciembre";

            default: 
                //lanza nuevo Argumento fuera de rango de excepcion
                throw new Exception(); 
                
        }
    }
}