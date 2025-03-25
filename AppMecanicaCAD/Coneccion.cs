using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AppMecanicaCAD
{
    public class Coneccion
    {
        private static string connectionString;

        static Coneccion()
        {
            // Ruta relativa al ejecutable
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "database.sqlite");




            // Crear la carpeta si no existe
            if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
            }

            connectionString = $"Data Source={dbPath};Version=3;";
        }



        public static SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
