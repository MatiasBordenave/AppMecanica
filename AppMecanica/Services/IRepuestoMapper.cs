using System.Collections.Generic;
using System.Windows.Forms;
using AppMecanicaCAD; 

namespace AppMecanica.Services
{
    public interface IRepuestoMapper
    {
        List<Repuesto> Map(DataGridView grid);
    }
}
