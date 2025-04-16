namespace AppMecanica
{
    public class Repuesto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Repuesto() { } // Necesario para inicialización por propiedades

        public Repuesto(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
