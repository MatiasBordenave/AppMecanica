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

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.sqlite");

            //string dbPath = $"C:\\Users\\Matias\\Desktop\\Nueva carpeta (2)\\AppMecanica\\Data\\database.sqlite";

            if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbPath));
            }
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                CrearTablas(dbPath); 
            }

            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private static void CrearTablas(string dbPath)
        {
            string queryUsuarios = @"CREATE TABLE clientes (id_cliente INTEGER PRIMARY KEY AUTOINCREMENT,
                                            nombreYApellido TEXT NOT NULL,
                                            telefono TEXT,
                                            domicilio TEXT TEXT UNIQUE,
                                            activo BOOLEAN DEFAULT 1 -- 1 = Activo, 0 = Dado de baja
                                        );

                                        -- Crear la tabla de vehículos
                                        CREATE TABLE vehiculos (
                                            id_vehiculo INTEGER PRIMARY KEY AUTOINCREMENT,
                                            id_cliente INTEGER NOT NULL,
                                            marca TEXT NOT NULL,
                                            modelo TEXT NOT NULL,
                                            año INTEGER NOT NULL,
                                            patente TEXT UNIQUE NOT NULL,
                                            kilometrajeInicial INTEGER NOT NULL,
                                            activo BOOLEAN DEFAULT 1, -- 1 = Activo, 0 = Dado de baja
                                            FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE
                                        );

                                       -- Crear la tabla de registros de mantenimiento
                                        CREATE TABLE registros (
                                            id_registro INTEGER PRIMARY KEY AUTOINCREMENT,
                                            id_vehiculo INTEGER NOT NULL,
                                            fecha TEXT NOT NULL DEFAULT (datetime('now')),
                                            descripcion TEXT NOT NULL,
                                            precioTotal      REAL NOT NULL, 
                                            totalRepuestos REAL NOT NULL,
                                            cantidadHoras INTEGER NOT NULL, 
                                            precioPorHora REAL NOT NULL, 
                                            precioTotalHoras REAL NOT NULL,
                                            kilometrajeRegistro INTEGER NOT NULL,
                                            descripcionRepuestos TEXT NOT NULL,                                     
                                            FOREIGN KEY (id_vehiculo) REFERENCES vehiculos(id_vehiculo) ON DELETE CASCADE
                                        );

                                        -- Crear la tabla de presupuesto
                                        CREATE TABLE presupuesto(id_presupuesto INTEGER PRIMARY KEY AUTOINCREMENT); ";


            try
            {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(queryUsuarios, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la tabla Users: " + ex.Message);
            }
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