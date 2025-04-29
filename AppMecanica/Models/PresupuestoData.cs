using System.Collections.Generic;
using AppMecanicaCAD;
using AppMecanicaEntidades;
using AppMecanica;

namespace AppMecanica.Models
{
    public class PresupuestoData
    {
        public List<Repuesto> Repuestos { get; set; }
        public decimal TotalRepuestos { get; set; }
        public decimal CantidadHoras { get; set; }
        public decimal PrecioHora { get; set; }
        public decimal TotalManoObra { get; set; }
        public decimal TotalGeneral { get; set; }
        public string Titular, Telefono, Marca, Modelo, Año, Desc;
    }
}
