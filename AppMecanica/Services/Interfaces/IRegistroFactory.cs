using AppMecanica;
using AppMecanicaEntidades;

public interface IRegistroFactory
{
    Registro CreateRegistro(
        string descripcion,
        decimal totalRepuestos,
        decimal cantidadHoras,
        decimal precioPorHora,
        decimal totalLabor,          // precioTotalHoras
        decimal totalGeneral,        // precioTotal
        int kilometraje,
        List<Repuesto>repuestos     // <— la lista completa
    );
}
