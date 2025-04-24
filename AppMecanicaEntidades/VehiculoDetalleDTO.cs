using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaEntidades
{
    public class VehiculoDetalleDTO
    {


        public string Titular { get; set; }
        public string TelefonoCliente { get; set; }
        public string DomicilioCliente { get; set; }

        // Datos del vehículo
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public int KilometrajeInicial { get; set; }

        // Lista de registros
        public List<Registro> Registros { get; set; } = new List<Registro>();

    }
}
