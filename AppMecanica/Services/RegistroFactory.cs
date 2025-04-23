using AppMecanicaEntidades;

public class RegistroFactory : IRegistroFactory
{
    public Registro CreateRegistro(string descripcion, decimal totalRepuestos,
                                   int horas, decimal precioHora, int kilometraje)
    {
        var precioTotalHoras = horas * precioHora;
        return new Registro
        {
            Fecha = DateTime.Now,
            Descripcion = descripcion,
            TotalRepuestos = (double)totalRepuestos,
            CantidadHoras = horas,
            PrecioPorHora = (double)precioHora,
            PrecioTotalHoras = (double)precioTotalHoras,
            PrecioTotal = (double)(totalRepuestos + (decimal)precioTotalHoras),
            KilometrajeRegistro = kilometraje
        };
    }
}
