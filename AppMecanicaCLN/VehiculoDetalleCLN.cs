using AppMecanicaCAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMecanicaEntidades;
using AppMecanicaCAD;

namespace AppMecanicaCLN
{
    public class VehiculoDetalleCLN
    {
        private VehiculoDetalleCAD vehiculoDetalleCAD = new VehiculoDetalleCAD();

        public VehiculoDetalleDTO ObtenerDetalleVehiculo(int idVehiculo)
        {
            return vehiculoDetalleCAD.ObtenerDetalleVehiculo(idVehiculo);
        }
    }

}
