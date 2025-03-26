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
                                    Id = Convert.ToInt32(reader["id_cliente"]),
                                    nombreYApellido = reader["nombreYApellido"].ToString(),
                                    Telefono = reader["telefono"].ToString(),
                                    Domicilio = reader["domicilio"].ToString()
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
    }
}

