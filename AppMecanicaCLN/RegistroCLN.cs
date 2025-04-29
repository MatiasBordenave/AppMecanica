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

        public static bool ExisteCliente(string patente)
        {
            return RegistroCAD.ExisteCliente(patente);
        }

        public static void AgregarRegistroHistorico(string patente, Registro registro)
        {
            // Asumimos que RegistroCAD tiene este método:
            RegistroCAD.AgregarRegistroHistorico(patente, registro);
        }

        public List<Registro> ObtenerRegistros()
        {
            return registroCAD.ObtenerRegistro();
        }


        public static void CrearClienteConRegistro(
        string nombreYApellido,
        string telefono,
        string domicilio,
        string marca,
        string modelo,
        string patente,
        int año,
        int kilometrajeInicial,
        Registro registro,
        Repuesto repuestos)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(nombreYApellido) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(patente))
            {
                throw new ArgumentException("Todos los campos de cliente y vehículo son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(registro.Descripcion))
            {
                throw new ArgumentException("La descripción es obligatoria.");
            }

            if (año <= 1900 || kilometrajeInicial < 0 || registro.CantidadHoras < 0 ||
                registro.PrecioPorHora < 0 || registro.TotalRepuestos < 0 || registro.KilometrajeRegistro < 0)
            {
                throw new ArgumentException("Los valores numéricos deben ser válidos.");
            }

            if (registro.Fecha == DateTime.MinValue)
            {
                throw new ArgumentException("La fecha proporcionada no es válida.");
            }

            registro.Repuestos = repuestos;

            try
            {
                RegistroCAD.AgregarRegistro(
                    nombreYApellido,
                    telefono,
                    domicilio,
                    marca,
                    modelo,
                    patente,
                    año,
                    kilometrajeInicial,
                    registro,
                    repuestos
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el registro: " + ex.Message);
            }
        }

        public int ObtenerTotalPaginas(int pageSize)
        {
            int totalRegistros = registroCAD.ObtenerTotalClientesConVehiculos();
            return (int)Math.Ceiling((double)totalRegistros / pageSize);
        }

    }
}
