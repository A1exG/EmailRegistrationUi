using System.Windows.Controls;

namespace EmailRegistrationUi.Services.Validator
{
    public class Validator : IValidator
    {
        // Проверка TextBox на пустое значение
        // Если не заполнен - контур у элемента в окне красный. 
        // Если заполнен - контур синий
        public bool CheckStringEmpty(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.BorderBrush = System.Windows.Media.Brushes.MediumVioletRed;
                return false;
            }
            else
            {
                textBox.BorderBrush = System.Windows.Media.Brushes.LightBlue;
                return true;
            }
        }

        // Проверка DatePicker на пустое значение
        // Если дата не выбрана - контур у элемента в окне красный. 
        // Если дата выбрана - контур синий
        public bool CheckDateTimeEmpty(DatePicker datePicker)
        {
            if (datePicker.SelectedDate == null)
            {
                datePicker.BorderBrush = System.Windows.Media.Brushes.MediumVioletRed;
                return false;
            }
            else
            {
                datePicker.BorderBrush = System.Windows.Media.Brushes.LightBlue;
                return true;
            }
        }
    }
}
