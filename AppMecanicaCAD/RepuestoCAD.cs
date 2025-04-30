using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMecanicaEntidades;

namespace AppMecanicaCAD
{
    public class RepuestoCAD
    {

        public List<Repuesto> ObtenerRepuestos()
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            string query = "SELECT * FROM repuesto;";
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
                                repuestos.Add(new Repuesto
                                {
                                    IdRepuesto = Convert.ToInt32(reader["id_repuesto"]),
                                    IdRegistro = Convert.ToInt32(reader["id_registro"]),
                                    Nombre = reader["nombre"].ToString(),
                                    Precio = Convert.ToDecimal(reader["precioUnitario"]), // Corregido
                                    Cantidad = Convert.ToInt32(reader["cantidad"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerRepuestos: " + ex.Message);
            }

            return repuestos;
        }


        public void AgregarRepuesto(Repuesto repuesto)
        {
            string query = "INSERT INTO repuestos (id_registro, nombre, cantidad, precio) VALUES (@id_registro, @nombre, @cantidad, @precio)";

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id_registro", repuesto.IdRegistro);
                            command.Parameters.AddWithValue("@nombre", repuesto.Nombre);
                            command.Parameters.AddWithValue("@cantidad", repuesto.Cantidad);
                            command.Parameters.AddWithValue("@precio", repuesto.Precio);

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en AgregarRepuesto: " + ex.Message);
            }
        }

    }
}
