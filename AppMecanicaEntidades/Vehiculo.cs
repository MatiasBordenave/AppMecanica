using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMecanicaEntidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public int KilometrajeInicial { get; set; }
        public bool Activo { get; set; } = true;

        // Relación con Cliente y Registros de mantenimiento
        public Cliente Cliente { get; set; }
        public List<Registro> Registros { get; set; } = new List<Registro>();

    }
}
