using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EmailRegistrationUi.Services.Validator
{
    public interface IValidator
    {
        bool CheckStringEmpty(TextBox textBox);

        bool CheckDateTimeEmpty(DatePicker datePicker);

    }
}
