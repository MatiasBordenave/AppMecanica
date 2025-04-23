public class FormCleaner : IFormCleaner
{
    public void ClearControls(IEnumerable<Control> controls)
    {
        foreach (var c in controls)
        {
            switch (c)
            {
                case TextBox t: t.Clear(); break;
                case NumericUpDown n: n.Value = n.Minimum; break;
                case DataGridView dgv: dgv.Rows.Clear(); break;
                    // …otros casos si los tienes
            }
        }
    }
}