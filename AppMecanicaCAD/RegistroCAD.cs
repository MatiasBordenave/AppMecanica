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


        public void AgregarRegistro(Registro registro)
        {
            string query = "INSERT INTO registros (id_Vehiculo, Fecha, Descripcion, PrecioTotal, TotalRepuestos, CantidadHoras, PrecioPorHora, PrecioTotalHoras, KilometrajeRegistro) " +
                            "VALUES ( @IdVehiculo, @Fecha, @Descripcion, @PrecioTotal, @TotalRepuestos, @CantidadHoras, @PrecioPorHora, @PrecioTotalHoras, @KilometrajeRegistro)";

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction()) // Inicia una transacción
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdVehiculo", registro.Vehiculo);
                            command.Parameters.AddWithValue("@Fecha", registro.Fecha);
                            command.Parameters.AddWithValue("@Descripcion", registro.Descripcion);
                            command.Parameters.AddWithValue("@PrecioTotal", registro.PrecioTotal);
                            command.Parameters.AddWithValue("@TotalRepuestos", registro.TotalRepuestos);
                            command.Parameters.AddWithValue("@CantidadHoras", registro.CantidadHoras);
                            command.Parameters.AddWithValue("@PrecioPorHora", registro.PrecioPorHora);
                            command.Parameters.AddWithValue("@PrecioTotalHoras", registro.PrecioTotalHoras);
                            command.Parameters.AddWithValue("@KilometrajeRegistro", registro.KilometrajeRegistro);

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en AgregarRegistro: " + ex.Message);
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