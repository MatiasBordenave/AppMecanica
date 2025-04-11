using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCAD
{
    public class VehiculoDetalleCAD
    {
        public VehiculoDetalleDTO ObtenerDetalleVehiculo(int idVehiculo)
            {
                VehiculoDetalleDTO detalle = new VehiculoDetalleDTO();

                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();

                    // Obtener datos del vehículo
                    string queryVehiculo = "SELECT * FROM vehiculos WHERE id_vehiculo = @idVehiculo";
                    using (SQLiteCommand command = new SQLiteCommand(queryVehiculo, connection))
                    {
                        command.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                detalle.IdVehiculo = Convert.ToInt32(reader["id_vehiculo"]);
                                detalle.Marca = reader["marca"].ToString();
                                detalle.Modelo = reader["modelo"].ToString();
                                detalle.Patente = reader["patente"].ToString();
                                detalle.Año = Convert.ToInt32(reader["año"]);
                            }
                        }
                    }

                    // Obtener los registros del vehículo
                    detalle.Registros = new List<Registro>();
                    string queryRegistros = "SELECT * FROM registros WHERE id_vehiculo = @idVehiculo";
                    using (SQLiteCommand command = new SQLiteCommand(queryRegistros, connection))
                    {
                        command.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detalle.Registros.Add(new Registro
                                {
                                    Id = Convert.ToInt32(reader["id_registro"]),
                                    IdVehiculo = Convert.ToInt32(reader["id_vehiculo"]),
                                    Fecha = DateTime.Parse(reader["fecha"].ToString()),
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

                return detalle;
            }

    }
}
