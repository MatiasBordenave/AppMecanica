namespace AppMecanicaEntidades
{
    public class Repuesto
    {
        public int IdRepuesto { get; set; }
        public int IdRegistro { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Repuesto() { }

        public Repuesto(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }

}
