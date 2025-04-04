namespace AppMecanicaEntidades
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombreYApellido { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public bool activo { get; set; } = true;

        // Relación con vehículos
        public List<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
}
