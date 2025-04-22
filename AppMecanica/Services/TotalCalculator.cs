using System.Linq;
using System.Collections.Generic;
using AppMecanicaCAD;

namespace AppMecanica.Services
{
    public class TotalCalculator : ITotalCalculator
    {
        public decimal CalculateTotalRepuestos(IEnumerable<Repuesto> repuestos)
            => repuestos.Sum(r => r.Precio);

        public decimal CalculateLaborCost(decimal horas, decimal precioHora)
            => horas * precioHora;

        public decimal CalculateTotalGeneral(IEnumerable<Repuesto> repuestos, decimal horas, decimal precioHora)
            => CalculateTotalRepuestos(repuestos)
             + CalculateLaborCost(horas, precioHora);
    }
}