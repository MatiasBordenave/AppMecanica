public class InputValidator : IInputValidator
{
    public bool AreRequiredFieldsFilled(IEnumerable<TextBox> campos)
    {
        return campos.All(tb => !string.IsNullOrWhiteSpace(tb.Text));
    }
    public bool TryParseDecimal(TextBox control, out decimal value)
    {
        return decimal.TryParse(control.Text, out value) && value >= 0;
    }
}