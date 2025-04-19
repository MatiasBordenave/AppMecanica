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
        
        
            private ClienteVehiculoCAD clientreVehiculoCAD = new ClienteVehiculoCAD();

        public List<ClienteVehiculo> ObtenerClientesConVehiculos(int offset, int limit)
        {
            var lista = clientreVehiculoCAD.ObtenerClientesConVehiculos(offset, limit);
            if (lista == null)
            {
                return new List<ClienteVehiculo>();
            }

            return lista;
        }

        public List<ClienteVehiculo> BuscarVehiculosPorCliente(string nombreCliente, int pagina, int pageSize)
        {
            return clientreVehiculoCAD.BuscarVehiculosPorCliente(nombreCliente, pagina, pageSize);
        }


        public int ObtenerCantidadTotalRegistros()
        {
            return clientreVehiculoCAD.ContarTodosLosRegistros();
        }

        public int ObtenerCantidadRegistrosPorCliente(string nombreCliente)
        {
            return clientreVehiculoCAD.ContarRegistrosPorCliente(nombreCliente);
        }


    }
}
