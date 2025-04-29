using System.Collections.Generic;
using AppMecanicaEntidades;
using AppMecanicaCAD;

namespace AppMecanica.Services.Interfaces
{
    public interface ITotalCalculator
    {
        decimal CalculateTotalRepuestos(IEnumerable<Repuesto> repuestos);
        decimal CalculateLaborCost(decimal horas, decimal precioHora);
        decimal CalculateTotalGeneral(IEnumerable<Repuesto> repuestos, decimal horas, decimal precioHora);
    }
}