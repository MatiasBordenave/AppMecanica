using AppMecanica;
using AppMecanicaEntidades;

public interface IRegistroService
{
    bool ClienteExiste(string patente);
    void SaveRegistro(
        string titular,
        string telefono,
        string domicilio,
        string marca,
        string modelo,
        string patente,
        int año,
        int kilometraje,
        Registro registro,
        List<Repuesto> repuestos
    );

}