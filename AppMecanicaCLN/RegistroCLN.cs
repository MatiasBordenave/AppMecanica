using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaCAD
{
    public class RegistroCLN
    {
        private RegistroCAD registroCAD = new RegistroCAD();


        public List<Registro> ObtenerRegistros()
        {
            return registroCAD.ObtenerRegistro();
        }


        public void AgregarRegistro(int IdVehiculo, DateTime Fecha, string Descripcion, double PrecioTotal, double TotalRepuestos, int CantidadHoras, double PrecioPorHora, double PrecioTotalHoras, int KilometrajeRegistro)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                throw new ArgumentException("La descripción es obligatoria.");
            }

            // Validar enteros y dobles
            if (IdVehiculo <= 0)
            {
                throw new ArgumentException("El ID del vehículo debe ser válido.");
            }

            if (PrecioTotal < 0 || TotalRepuestos < 0 || CantidadHoras < 0 || PrecioPorHora < 0 || PrecioTotalHoras < 0 || KilometrajeRegistro < 0)
            {
                throw new ArgumentException("Los valores numéricos deben ser mayores o iguales a cero.");
            }

            // Validar la fecha (opcional: podrías validar que no sea futura o muy antigua)
            if (Fecha == DateTime.MinValue)
            {
                throw new ArgumentException("La fecha proporcionada no es válida.");
            }

            try
            {
                Registro registro = new Registro
                {
                    IdVehiculo = IdVehiculo,
                    Fecha = Fecha,
                    Descripcion = Descripcion,
                    PrecioTotal = PrecioTotal,
                    TotalRepuestos = TotalRepuestos,
                    CantidadHoras = CantidadHoras,
                    PrecioPorHora = PrecioPorHora,
                    PrecioTotalHoras = PrecioTotalHoras,
                    KilometrajeRegistro = KilometrajeRegistro
                };

                registroCAD.AgregarRegistro(registro);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro: " + ex.Message);
            }
        }

    }
}
