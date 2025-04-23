using AppMecanicaEntidades;

public interface IRegistroFactory
{
    Registro CreateRegistro(
        string descripcion,
        decimal totalRepuestos,
        int horas,
        decimal precioHora,
        int kilometraje);
}