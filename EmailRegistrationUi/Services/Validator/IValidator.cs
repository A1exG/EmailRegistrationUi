using System.Windows.Controls;

namespace EmailRegistrationUi.Services.Validator
{
    public interface IValidator
    {
        bool CheckStringEmpty(TextBox textBox);

        bool CheckDateTimeEmpty(DatePicker datePicker);

    }
}
