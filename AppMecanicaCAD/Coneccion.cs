using System.Data.SQLite;

namespace AppMecanicaCAD
{
    public class Coneccion
    {
        private static string connectionString;

        static Coneccion()
        {

            // Ruta MAtias

            string rutaBaseDatos = @"C:\Users\Matias\Desktop\Nueva carpeta (3)\AppMecanica\Data\database.sqlite";

            connectionString = $"Data Source={rutaBaseDatos}";
 
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
