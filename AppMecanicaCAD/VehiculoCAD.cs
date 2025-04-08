using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCAD
{
    public class VehiculoCAD
    {
            public List<Vehiculo> ObtenerVehiculos()
            {

                List<Vehiculo> vehiculos = new List<Vehiculo>();
                string query = "SELECT * FROM vehiculos;";

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
                                vehiculos.Add(new Vehiculo
                                {
                                    Id = Convert.ToInt32(reader["id_vehiculo"]),
                                    IdCliente = Convert.ToInt32(reader["id_cliente"]),
                                    Marca = reader["marca"].ToString(),
                                    Modelo = reader["modelo"].ToString(),
                                    Año = Convert.ToInt32(reader["año"]),
                                    Patente = reader["patente"].ToString(),
                                    KilometrajeInicial = Convert.ToInt32(reader["kilometrajeInicial"]),
                                    Activo = Convert.ToBoolean(reader["activo"])
                                });
                            }
                        }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en ObtenerVehiculo: " + ex.Message);
                }

                return vehiculos;
            }


            public void AgregarVehiculo(Vehiculo vehiculo)
            {
                string query = "INSERT INTO vehiculos (id_Cliente, Marca, Modelo, Año, Patente, KilometrajeInicial ,activo) " +
                                "VALUES (@IdCliente, @Marca, @Modelo, @Año, @Patente, @KilometrajeInicial ,1)";

                try
                {
                    using (SQLiteConnection connection = Coneccion.CreateConnection())
                    {
                        connection.Open();
                        using (var transaction = connection.BeginTransaction()) // Inicia una transacción
                        {
                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@IdCliente", vehiculo.IdCliente);
                                command.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                                command.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                                command.Parameters.AddWithValue("@Año", vehiculo.Año);
                                command.Parameters.AddWithValue("@Patente", vehiculo.Patente);
                                command.Parameters.AddWithValue("@KilometrajeInicial", vehiculo.KilometrajeInicial);

                            command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error en AgregarVehiculo: " + ex.Message);
                }
            }
    }
}