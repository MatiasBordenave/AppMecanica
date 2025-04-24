public interface IMessageService
{
    void ShowInfo(string text, string caption);
    void ShowWarning(string text, string caption);
    void ShowError(string text, string caption);
    bool ShowConfirmation(string text, string caption);
}