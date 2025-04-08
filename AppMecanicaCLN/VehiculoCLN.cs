using AppMecanicaCAD;
using AppMecanicaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppMecanicaCLN
{
    public class VehiculoCLN
    {
        private VehiculoCAD vehiculoCAD = new VehiculoCAD();


        public List<Vehiculo> ObtenerVehiculos()
        {
            return vehiculoCAD.ObtenerVehiculos();
        }


        public void AgregarVehiculo(int IdCliente, string Marca, string Modelo, int Año, string Patente, int KilometrajeInicial)
        {

            // Validar strings vacíos
            if (string.IsNullOrWhiteSpace(Marca) || string.IsNullOrWhiteSpace(Modelo) || string.IsNullOrWhiteSpace(Patente))
            {
                throw new ArgumentException("Marca, Modelo y Patente son campos obligatorios.");
            }

            // Validar enteros no negativos (o > 0 según tu lógica)
            if (IdCliente <= 0 || Año <= 0 || KilometrajeInicial < 0)
            {
                throw new ArgumentException("IdCliente, Año y KilometrajeInicial deben ser valores válidos.");
            }


            try
            {
                Vehiculo vehiculo = new Vehiculo
                {
                    IdCliente = IdCliente,
                    Marca = Marca,
                    Modelo = Modelo,
                    Año = Año,
                    Patente = Patente,
                    KilometrajeInicial = KilometrajeInicial
                };

                vehiculoCAD.AgregarVehiculo(vehiculo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el vehiculo: " + ex.Message);
            }
        }
    }
}
