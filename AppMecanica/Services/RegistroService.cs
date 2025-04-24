using AppMecanicaCAD;
using AppMecanicaEntidades;

public class RegistroService : IRegistroService
{
    public void SaveRegistro(string titular, string telefono, string domicilio,
                             string marca, string modelo, string patente,
                             int año, int kilometraje, Registro registro)
    {
        RegistroCLN.AgregarRegistro(
            titular, telefono, domicilio,
            marca, modelo, patente, año, kilometraje, registro);
    }
}