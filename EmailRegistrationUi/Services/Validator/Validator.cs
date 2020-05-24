using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EmailRegistrationUi.Services.Validator
{
    public class Validator : IValidator
    {
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
