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
        public List<ClienteVehiculo> ObtenerClientesConVehiculos()
        {
            List<ClienteVehiculo> lista = new List<ClienteVehiculo>();

            using (var connection = Coneccion.CreateConnection())
            {
                connection.Open();

                string query = @"SELECT 
                                    c.id_cliente,
                                    v.id_vehiculo,
                                    v.marca,
                                    v.modelo,
                                    c.nombreYApellido,
                                    v.patente
                                FROM clientes c
                                INNER JOIN vehiculos v ON c.id_cliente = v.id_cliente
                                WHERE c.activo = 1 AND v.activo = 1";

                using (var cmd = new SQLiteCommand(query, connection))
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

            return lista;
        }

        public List<ClienteVehiculo> BuscarVehiculosPorCliente(string nombreCliente)
        {
            string query = @"SELECT 
                                c.id_cliente,
                                v.id_vehiculo,
                                v.marca,
                                v.modelo,
                                c.nombreYApellido,
                                v.patente
                            FROM clientes c
                            INNER JOIN vehiculos v ON c.id_cliente = v.id_cliente
                            WHERE c.nombreYApellido LIKE @nombreCliente;";

            List<ClienteVehiculo> lista = new List<ClienteVehiculo>();

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombreCliente", $"%{nombreCliente}%");

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

    }
}
