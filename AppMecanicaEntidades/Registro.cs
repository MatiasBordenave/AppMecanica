using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMecanicaEntidades;

namespace AppMecanicaEntidades
{
    public class Registro
    {
        public int Id { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; }

        public double PrecioTotal { get; set; }
        public double TotalRepuestos { get; set; }
        public int CantidadHoras { get; set; }
        public double PrecioPorHora { get; set; }
        public double PrecioTotalHoras { get; set; }
        public int KilometrajeRegistro { get; set; }

        public string DescripcionRepuestos { get; set; }

        // Relación con Vehículo
        public Vehiculo Vehiculo { get; set; }
    }
}
