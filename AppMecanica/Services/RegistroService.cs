using AppMecanica;
using AppMecanicaCAD;
using AppMecanicaEntidades;

public class RegistroService : IRegistroService
{
    /// <inheritdoc />
    public bool ClienteExiste(string patente)
    {
        // Llama a la capa de datos para verificar existencia de cliente por patente
        return RegistroCLN.ExisteCliente(patente);
    }
    public void SaveRegistro(
        string titular,
        string telefono,
        string domicilio,
        string marca,
        string modelo,
        string patente,
        int año,
        int kilometraje,
        Registro registro,
        Repuesto repuestos
        )
    {
        if (ClienteExiste(patente))
        {
            // Agrega registro al historial de cliente existente
            RegistroCLN.AgregarRegistroHistorico(patente, registro);
        }
        else
        {
            // Crea cliente nuevo con su primer registro
            RegistroCLN.CrearClienteConRegistro(
                titular, telefono, domicilio,
                marca, modelo, patente,
                año, kilometraje, registro, repuestos);
        }
    }
}