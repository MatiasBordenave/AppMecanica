using AppMecanica;
using AppMecanicaEntidades;

public class RegistroFactory : IRegistroFactory
{
    public Registro CreateRegistro(
     string descripcion,
     decimal totalRepuestos,
     decimal cantidadHoras,
     decimal precioPorHora,
     decimal totalLabor,
     decimal totalGeneral,
     int kilometraje,
     List<Repuesto> repuestos)
    {
        return new Registro
        {
            Descripcion = descripcion,
            TotalRepuestos = (double)totalRepuestos,
            CantidadHoras = (int)cantidadHoras,
            PrecioPorHora = (double)precioPorHora,
            PrecioTotalHoras = (double)totalLabor,
            PrecioTotal = (double)totalGeneral,
            KilometrajeRegistro = kilometraje,
            Fecha = DateTime.Now,
            Repuestos = repuestos
        };
    }
}
