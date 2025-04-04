using AppMecanicaCAD;
using AppMecanicaEntidades;

namespace AppMecanicaCLN
{
    public class ClienteCLN
    {
        private ClienteCAD clienteCAD = new ClienteCAD();


        public List<Cliente> ObtenerClientes()
        {
            return clienteCAD.ObtenerCliente();
        }


        public void AgregarCliente(string nombreYApellido, string telefono, string domicilio)
        {

            if (string.IsNullOrWhiteSpace(nombreYApellido) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(domicilio))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            try
            {
                Cliente cliente = new Cliente
                {
                    nombreYApellido = nombreYApellido,
                    telefono = telefono,
                    domicilio = domicilio
                };

                clienteCAD.AgregarCliente(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
        }
    }
}
