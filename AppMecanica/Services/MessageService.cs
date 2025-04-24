public class MessageService : IMessageService
{
    public void ShowInfo(string text, string caption) =>
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    public void ShowWarning(string text, string caption) =>
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    public void ShowError(string text, string caption) =>
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    public bool ShowConfirmation(string text, string caption) =>
        MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        == DialogResult.Yes;
}