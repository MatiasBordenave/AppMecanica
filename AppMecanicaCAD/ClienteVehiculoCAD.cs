using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMecanicaEntidades;

namespace AppMecanicaCAD
{
    public class ClienteVehiculoCAD
    {
        public List<ClienteVehiculo> ObtenerClientesConVehiculos(int offset, int limit)
        {
            List<ClienteVehiculo> lista = new List<ClienteVehiculo>();

            using (var connection = Coneccion.CreateConnection())
            {
                connection.Open();

                string query = @"SELECT c.id_cliente,
                                        v.id_vehiculo,
                                        v.marca,
                                        v.modelo,
                                        c.nombreYApellido,
                                        v.patente,
                                        COUNT(r.id_registro) AS cantidad_registros
                                    FROM clientes c
                                    INNER JOIN vehiculos v ON c.id_cliente = v.id_cliente
                                    INNER JOIN registros r ON v.id_vehiculo = r.id_vehiculo
                                    WHERE c.activo = 1 AND v.activo = 1
                                    GROUP BY v.id_vehiculo
                                    LIMIT @limit OFFSET @offset";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@limit", limit);
                    cmd.Parameters.AddWithValue("@offset", offset);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ClienteVehiculo
                            {
                                IdCliente = Convert.ToInt32(reader["id_cliente"]),
                                IdVehiculo = Convert.ToInt32(reader["id_vehiculo"]),
                                Marca = reader["marca"].ToString(),
                                Modelo = reader["modelo"].ToString(),
                                Titular = reader["nombreYApellido"].ToString(),
                                Patente = reader["patente"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }


        public List<ClienteVehiculo> BuscarVehiculosPorCliente(string nombreCliente, int pagina, int pageSize)
        {
            string query = @"SELECT c.id_cliente,
                                    c.nombreYApellido,
                                    v.id_vehiculo,
                                    v.marca,
                                    v.modelo,
                                    v.patente
                                FROM clientes c
                                INNER JOIN vehiculos v ON c.id_cliente = v.id_cliente
                                INNER JOIN registros r ON v.id_vehiculo = r.id_vehiculo
                                WHERE 
                                    c.activo = 1 
                                    AND v.activo = 1
                                    AND (
                                        @nombreCliente IS NULL OR
                                        LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(c.nombreYApellido, 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u'))
                                        LIKE LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@nombreCliente, 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u'))
                                    )
                                GROUP BY v.id_vehiculo;";

            List<ClienteVehiculo> lista = new List<ClienteVehiculo>();

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreCliente",
                            string.IsNullOrEmpty(nombreCliente) ? DBNull.Value : $"%{nombreCliente}%");

                        int offset = (pagina - 1) * pageSize;
                        command.Parameters.AddWithValue("@pageSize", pageSize);
                        command.Parameters.AddWithValue("@offset", offset);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new ClienteVehiculo
                                {
                                    IdCliente = Convert.ToInt32(reader["id_cliente"]),
                                    IdVehiculo = Convert.ToInt32(reader["id_vehiculo"]),
                                    Marca = reader["marca"].ToString(),
                                    Modelo = reader["modelo"].ToString(),
                                    Titular = reader["nombreYApellido"].ToString(),
                                    Patente = reader["patente"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en BuscarVehiculosPorCliente: " + ex.Message);
            }

            return lista;
        }

        public int ContarTodosLosRegistros()
        {
            int total = 0;

            string query = "SELECT COUNT(*) FROM vehiculos v INNER JOIN clientes c ON v.id_cliente = c.id_cliente";

            try
            {
                using (SQLiteConnection conexion = Coneccion.CreateConnection())
                {
                    conexion.Open();
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        total = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ContarTodosLosRegistros: " + ex.Message);
            }

            return total;
        }



        public int ContarRegistrosPorCliente(string nombreCliente)
        {
            int total = 0;

            string query = @"SELECT COUNT(*) 
                            FROM vehiculos v 
                            INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                            WHERE 
                                LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(c.nombreYApellido, 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u')) 
                                LIKE LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@nombreCliente, 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u'))";

            try
            {
                using (SQLiteConnection conexion = Coneccion.CreateConnection())
                {
                    conexion.Open();
                    using (SQLiteCommand comando = new SQLiteCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@nombreCliente", "%" + nombreCliente + "%");
                        total = Convert.ToInt32(comando.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ContarRegistrosPorCliente: " + ex.Message);
            }

            return total;
        }

    }
}
