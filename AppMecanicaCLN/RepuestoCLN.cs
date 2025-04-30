using AppMecanicaCAD;
using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCLN
{
    public class RepuestoCLN
    {

        public List<Repuesto> ObtenerRepuestos()
        {
            return repuestoCAD.ObtenerRepuestos();
        }


        private RepuestoCAD repuestoCAD = new RepuestoCAD();
        public void AgregarRepuesto(int idRegistro, string nombre, int cantidad, decimal precio)
        {
            if (idRegistro <= 0 || string.IsNullOrWhiteSpace(nombre) || cantidad <= 0 || precio <= 0)
            {
                throw new ArgumentException("Todos los campos de repuesto deben ser válidos y completos.");
            }

            try
            {
                Repuesto repuesto = new Repuesto
                {
                    IdRegistro = idRegistro,
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Precio = precio
                };

                repuestoCAD.AgregarRepuesto(repuesto);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el repuesto: " + ex.Message);
            }
        }

    }
}
