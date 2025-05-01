using AppMecanicaEntidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
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
                                    KilometrajeRegistro = Convert.ToInt32(reader["kilometrajeRegistro"]),
                                    DescripcionRepuestos = reader["descripcionRepuestos"].ToString()
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
    int kilometrajeInicial, Registro registro)
        {
            using (var connection = Coneccion.CreateConnection())
            {
                connection.Open();

                int idCliente;
                string nombreNormalizado = QuitarTildes(nombreYApellido).ToLower();

                string queryCliente = "SELECT id_cliente, nombreYApellido FROM clientes";
                using (var cmd = new SQLiteCommand(queryCliente, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        idCliente = -1;
                        while (reader.Read())
                        {
                            string nombreExistente = reader.GetString(1);
                            string nombreExistenteNormalizado = QuitarTildes(nombreExistente).ToLower();
                            if (nombreExistenteNormalizado == nombreNormalizado)
                            {
                                idCliente = reader.GetInt32(0);
                                break;
                            }
                        }
                    }
                }

                if (idCliente == -1)
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

                string patenteNormalizada = QuitarTildes(patente).ToUpper();
                int idVehiculo;
                string queryVehiculo = "SELECT id_vehiculo, patente FROM vehiculos";
                using (var cmd = new SQLiteCommand(queryVehiculo, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        idVehiculo = -1;
                        while (reader.Read())
                        {
                            string patenteExistente = reader.GetString(1);
                            string patenteExistenteNormalizada = QuitarTildes(patenteExistente).ToUpper();
                            if (patenteExistenteNormalizada == patenteNormalizada)
                            {
                                idVehiculo = reader.GetInt32(0);
                                break;
                            }
                        }
                    }
                }

                if (idVehiculo == -1)
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

                int idRegistro;

                string insertRegistro = @"INSERT INTO registros 
            (id_vehiculo, fecha, descripcion, totalRepuestos, cantidadHoras, precioPorHora, precioTotalHoras, precioTotal, kilometrajeRegistro, descripcionRepuestos)
            VALUES 
            (@Vehiculo, @Fecha, @Descripcion, @Repuestos, @Horas, @PrecioHora, @TotalHoras, @TotalFinal, @KmRegistro, @descripcionRepuestos)";
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
                    cmd.Parameters.AddWithValue("@descripcionRepuestos", registro.DescripcionRepuestos);
                    cmd.ExecuteNonQuery();
                    idRegistro = (int)connection.LastInsertRowId;
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

        public static string QuitarTildes(string texto)
        {
            var textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in textoNormalizado)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}