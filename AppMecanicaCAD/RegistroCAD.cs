using AppMecanicaEntidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCAD
{
    public class RegistroCAD

    {
        public static bool ExisteCliente(string patente) {
            if (patente != null)
            {
                int cantidad = 0; // este valor debería salir de la base de datos
                                  // ejecutar consulta y asignar valor a cantidad...
                return cantidad > 0;
            }

            return false;
        }
        public static void AgregarRegistroHistorico(string patente, Registro r) { /* INSERT en tabla de registros */ }
        public static void CrearClienteConRegistro(/* todos los campos */) { /* INSERT en cliente + INSERT en registro */ }

        public List<Registro> ObtenerRegistro()
        {



            List<Registro> registros = new List<Registro>();
            string query = "SELECT * FROM registros;";

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                registros.Add(new Registro
                                {
                                    IdVehiculo = Convert.ToInt32(reader["id_vehiculo"]),
                                    Fecha = Convert.ToDateTime(reader["fecha"]),
                                    Descripcion = reader["descripcion"].ToString(),
                                    PrecioTotal = Convert.ToDouble(reader["precioTotal"]),
                                    TotalRepuestos = Convert.ToDouble(reader["totalRepuestos"]),
                                    CantidadHoras = Convert.ToInt32(reader["cantidadHoras"]),
                                    PrecioPorHora = Convert.ToDouble(reader["precioPorHora"]),
                                    PrecioTotalHoras = Convert.ToDouble(reader["precioTotalHoras"]),
                                    KilometrajeRegistro = Convert.ToInt32(reader["kilometrajeRegistro"])
                                });

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerRegistro: " + ex.Message);
            }

            return registros;
        }


        public static void AgregarRegistro(string nombreYApellido, string telefono, string domicilio, string marca, string modelo, string patente, int año,
       int kilometrajeInicial, Registro registro, Repuesto repuesto)
        {
            using (var connection = Coneccion.CreateConnection())
            {
                connection.Open();

                int idCliente;
                string queryCliente = "SELECT id_cliente FROM clientes WHERE nombreYApellido = @Nombre";
                using (var cmd = new SQLiteCommand(queryCliente, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreYApellido);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idCliente = Convert.ToInt32(result);
                    }
                    else
                    {
                        string insertCliente = @"INSERT INTO clientes (nombreYApellido, telefono, domicilio)
                                         VALUES (@Nombre, @Telefono, @Domicilio)";
                        using (var insertCmd = new SQLiteCommand(insertCliente, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@Nombre", nombreYApellido);
                            insertCmd.Parameters.AddWithValue("@Telefono", telefono);
                            insertCmd.Parameters.AddWithValue("@Domicilio", domicilio);
                            insertCmd.ExecuteNonQuery();
                            idCliente = (int)connection.LastInsertRowId;
                        }
                    }
                }

                int idVehiculo;
                string queryVehiculo = "SELECT id_vehiculo FROM vehiculos WHERE patente = @Patente";
                using (var cmd = new SQLiteCommand(queryVehiculo, connection))
                {
                    cmd.Parameters.AddWithValue("@Patente", patente);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idVehiculo = Convert.ToInt32(result);
                    }
                    else
                    {
                        string insertVehiculo = @"INSERT INTO vehiculos (id_cliente, marca, modelo, año, patente, kilometrajeInicial)
                                          VALUES (@IdCliente, @Marca, @Modelo, @Año, @Patente, @Km)";
                        using (var insertCmd = new SQLiteCommand(insertVehiculo, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@IdCliente", idCliente);
                            insertCmd.Parameters.AddWithValue("@Marca", marca);
                            insertCmd.Parameters.AddWithValue("@Modelo", modelo);
                            insertCmd.Parameters.AddWithValue("@Año", año);
                            insertCmd.Parameters.AddWithValue("@Patente", patente);
                            insertCmd.Parameters.AddWithValue("@Km", kilometrajeInicial);
                            insertCmd.ExecuteNonQuery();
                            idVehiculo = (int)connection.LastInsertRowId;
                        }
                    }
                }

                string insertRegistro = @"INSERT INTO registros 
            (id_vehiculo, fecha, descripcion, totalRepuestos, cantidadHoras, precioPorHora, precioTotalHoras, precioTotal, kilometrajeRegistro)
            VALUES 
            (@Vehiculo, @Fecha, @Descripcion, @Repuestos, @Horas, @PrecioHora, @TotalHoras, @TotalFinal, @KmRegistro)";
                using (var cmd = new SQLiteCommand(insertRegistro, connection))
                {
                    cmd.Parameters.AddWithValue("@Vehiculo", idVehiculo);
                    cmd.Parameters.AddWithValue("@Fecha", registro.Fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", registro.Descripcion);
                    cmd.Parameters.AddWithValue("@Repuestos", registro.TotalRepuestos);
                    cmd.Parameters.AddWithValue("@Horas", registro.CantidadHoras);
                    cmd.Parameters.AddWithValue("@PrecioHora", registro.PrecioPorHora);
                    cmd.Parameters.AddWithValue("@TotalHoras", registro.PrecioTotalHoras);
                    cmd.Parameters.AddWithValue("@TotalFinal", registro.PrecioTotal);
                    cmd.Parameters.AddWithValue("@KmRegistro", registro.KilometrajeRegistro);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public int ObtenerTotalClientesConVehiculos()
        {
            int total = 0;

            using (var connection = Coneccion.CreateConnection())
            {
                connection.Open();

                string query = @"SELECT COUNT(*) FROM clientes c
                         INNER JOIN vehiculos v ON c.id_cliente = v.id_cliente
                         WHERE c.activo = 1 AND v.activo = 1";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return total;
        }
    }
}