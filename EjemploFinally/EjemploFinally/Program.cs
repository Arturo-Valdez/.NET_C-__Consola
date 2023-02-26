internal class Program
{
    private static void Main(string[] args)
    {
        //Crea instancia StramReader guardar la ruta al archivo
        System.IO.StreamReader archivo = null;

        try
        {

            string linea;
            int contador = 0;

            //es nesesario el @ para las rutas en desktop
            string ruta = @"C:\Users\artur\Desktop\dato.txt";

            archivo = new System.IO.StreamReader(ruta);

            //LEE EL ARCHIVO HASTA QUE EN LA SIGUIENTE LINEA SEA NULL
            while((linea = archivo.ReadLine()) != null) 
            {
                Console.WriteLine(linea);

                contador++;
            }

        }
        catch(Exception e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
        }
        //finally es necesario para archivos y bases de datos que se requieren cerrar
        finally
        {
            if(archivo != null)
            {
                archivo.Close();
            }
            Console.WriteLine("Conexion de fichero  cerrada");
        }
        
    }
}