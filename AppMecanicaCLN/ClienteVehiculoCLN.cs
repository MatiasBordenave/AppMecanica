using AppMecanicaCAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMecanicaEntidades;
using System.Data.SQLite;

namespace AppMecanicaCLN
{
    public class ClienteVehiculoCLN
    {
        
        
            private ClienteVehiculoCAD accesoDatos = new ClienteVehiculoCAD();

            public List<ClienteVehiculo> ObtenerClientesConVehiculos()
            {
                return accesoDatos.ObtenerClientesConVehiculos();
            }

        public List<ClienteVehiculo> BuscarVehiculosPorCliente(string nombreCliente)
        {
            return accesoDatos.BuscarVehiculosPorCliente(nombreCliente);
        }



    }
}
