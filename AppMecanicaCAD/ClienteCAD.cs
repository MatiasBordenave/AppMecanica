using System.Data.SQLite;

namespace AppMecanicaCAD
{
    public class ClienteCAD
    {
        public List<Cliente> ObtenerCliente()
        {
            List<Cliente> clientes = new List<Cliente>();
            string query = "SELECT * FROM clientes";

            try
            {
                using (SQLiteConnection connection = Coneccion.CreateConnection()) // Usa el helper correcto
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
                                    Id = Convert.ToInt32(reader["Id"]),
                                    nombreYApellido = reader["nombreYApellido"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Domicilio = reader["Domicilio"].ToString()
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

            return clientes; // Corrige el nombre de la variable retornada
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string nombreYApellido { get; set; }
        public string Telefono { get; set; }
        public string Domicilio { get; set; }
    }

}

