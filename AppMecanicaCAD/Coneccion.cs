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
            string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", ".env");
            var env = EnvLoader.Load(envPath);

            string dbPath = env["DB_PATH"];

            connectionString = $"Data Source={dbPath};Version=3;";
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
