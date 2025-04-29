using System.Collections.Generic;
using System.Windows.Forms;
using AppMecanicaCAD;
using AppMecanicaEntidades;


namespace AppMecanica.Services.Interfaces
{
    public interface IRepuestoMapper
    {
        List<Repuesto> Map(DataGridView grid);
    }
}
