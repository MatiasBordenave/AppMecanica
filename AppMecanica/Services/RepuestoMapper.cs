using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppMecanica.Services.Interfaces;
using AppMecanicaCAD;
using AppMecanicaEntidades;

namespace AppMecanica.Services
{
    public class RepuestoMapper : IRepuestoMapper
    {
        public List<Repuesto> Map(DataGridView grid)
        {
            var lista = new List<Repuesto>();

            foreach (DataGridViewRow fila in grid.Rows)
            {
                if (fila.Cells[0].Value != null &&
                    fila.Cells[1].Value != null &&
                    fila.Cells[2].Value != null)
                {
                    lista.Add(new Repuesto
                    {
                        Nombre = fila.Cells[0].Value.ToString(),
                        Cantidad = Convert.ToInt32(fila.Cells[1].Value),
                        Precio = Convert.ToDecimal(fila.Cells[2].Value)
                    });
                }
            }

            return lista;
        }
    }
}
