using AppMecanicaEntidades;

public interface IRegistroService
{
    void SaveRegistro(
        string titular,
        string telefono,
        string domicilio,
        string marca,
        string modelo,
        string patente,
        int año,
        int kilometraje,
        Registro registro);
}