using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCAD
{
    public class PresupuestoCAD
    {

            public int AgregarPresupuesto()
{
    int idGenerado = -1;
    string query = "INSERT INTO presupuesto DEFAULT VALUES;";

    try
    {
        using (SQLiteConnection connection = Coneccion.CreateConnection())
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    // Recuperar el último ID insertado
                    command.CommandText = "SELECT last_insert_rowid();";
                    idGenerado = Convert.ToInt32(command.ExecuteScalar());
                }
                transaction.Commit();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error en AgregarPresupuesto: " + ex.Message);
    }

    return idGenerado;
}

    }
}
