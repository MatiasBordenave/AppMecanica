using System.Data.Entity;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppMecanicaCAD
{
    public class Coneccion
    {
        private static string connectionString;

        static Coneccion()
        {

            // Ruta MAtias


            string rutaMatias = @"C:\Users\Matias\Desktop\Nueva carpeta (3)\AppMecanica\Data\database.sqlite";

        

            string rutaBaseDatos = @"C:\Users\byfre\Source\Repos\AppMecanica\AppMecanica\Data\database.sqlite";

            connectionString = $"Data Source={rutaMatias}";
 
        }



        public static SQLiteConnection CreateConnection()
        {
            try
            {
                var connection = new SQLiteConnection(connectionString);
                Console.WriteLine("Conexión creada correctamente.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                throw;
            }
        }
    }
}
