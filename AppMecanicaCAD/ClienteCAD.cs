using System.Data.SQLite;
using AppMecanicaEntidades;

namespace AppMecanicaCAD
{
    public class ClienteCAD
    {
        public List<Cliente> ObtenerCliente()
        {

            List<Cliente> clientes = new List<Cliente>();
            string query = "select * from clientes;";

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
                                clientes.Add(new Cliente
                                {
                                    id = Convert.ToInt32(reader["id_cliente"]),
                                    nombreYApellido = reader["nombreYApellido"].ToString(),
                                    telefono = reader["telefono"].ToString(),
                                    domicilio = reader["domicilio"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerCliente: " + ex.Message);
            }

            return clientes;
        }


        public void AgregarCliente(Cliente cliente)
        {
            string query = "INSERT INTO clientes (nombreYApellido, telefono, domicilio, activo) VALUES (@nombreYApellido, @telefono, @domicilio, 1)";

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction()) // Inicia una transacción
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nombreYApellido", cliente.nombreYApellido);
                            command.Parameters.AddWithValue("@telefono", cliente.telefono);
                            command.Parameters.AddWithValue("@domicilio", cliente.domicilio);

                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en InsertarUsuario: " + ex.Message);
            }
        }
    }
}

