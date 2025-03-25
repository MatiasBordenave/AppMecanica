using AppMecanicaCAD;
using AppMecanicaEntidades;

namespace AppMecanicaCLN
{
    public class ClienteCLN
    {
        private ClienteCAD clienteCAD = new ClienteCAD();

        // Método para obtener clientes
        public List<Cliente> ObtenerClientes()
        {
            return clienteCAD.ObtenerCliente();
        }

        // Método para agregar un cliente
        public void AgregarCliente(string nombreYApellido, string telefono, string domicilio)
        {
            // Validaciones de negocio
            if (string.IsNullOrWhiteSpace(nombreYApellido) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(domicilio))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            try
            {
                // Crear un objeto Cliente
                Cliente cliente = new Cliente
                {
                    nombreYApellido = nombreYApellido,
                    Telefono = telefono,
                    Domicilio = domicilio
                };

                // Insertar el cliente en la base de datos
                //clienteCAD.guardarCliente(cliente);   !!!!!!!!!! FALTA FUNCION PARA INSERTAR CLIENTE !!!!!!!!!!
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
        }
    }
}
