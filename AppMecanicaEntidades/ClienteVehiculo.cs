using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaEntidades
{
    public class ClienteVehiculo
    {
        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Titular { get; set; }
        public string Patente { get; set; }
    }
}
