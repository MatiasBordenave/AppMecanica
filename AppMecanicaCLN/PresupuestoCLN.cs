using AppMecanicaCAD;
using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCLN
{
    public class PresupuestoCLN
    {

        private PresupuestoCAD presupuestoCAD = new PresupuestoCAD();



        // Nuevo método para insertar presupuesto y obtener el ID
        public int CrearNuevoPresupuesto()
        {
            try
            {
                return presupuestoCAD.AgregarPresupuesto(); // Esto devuelve el nuevo ID insertado
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear nuevo presupuesto: " + ex.Message);
            }
        }
    }
}
