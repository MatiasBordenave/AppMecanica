public interface IInputValidator
{
    bool AreRequiredFieldsFilled(IEnumerable<TextBox> campos);
    bool TryParseDecimal(TextBox control, out decimal value);
}