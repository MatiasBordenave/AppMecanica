using System.Drawing;
using System.Windows.Forms;

namespace AppMecanica.Servicios
{
    public interface IPdfGenerator
    {
        void GenerarDesdePanel(Panel panel, string tituloArchivo);
    }
}
