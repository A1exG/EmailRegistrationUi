using EmailRegistrationUi.EmailRegistrationWebService;
using EmailRegistrationUi.Services.Validator;
using FluentValidation.Results;
using NLog;
using System.Windows;

namespace EmailRegistrationUi.Views
{
    public partial class AddNewEmailView : Window
    {
        public AddNewEmailView(WebService _webService, EmailValidator _validator, Logger _logger)
        {
            InitializeComponent();

            var EmailRegistrationDate = dpEmailRegistrationDate.DisplayDate.Date;

            btnClose.Click += (s, e) =>
            {
                this.Close();
            };
            
            btnSave.Click += (s, e) =>
            {
                Email email = new Email();
                email.EmailName = txtEmailName.Text;
                email.EmailRegistrationDate = EmailRegistrationDate;
                email.EmailTo = txtEmailTo.Text;
                email.EmailFrom = txtEmailFrom.Text;
                email.EmailTag = txtEmailTag.Text;
                email.EmailContent = txtEmailContent.Text;

                ValidationResult result = _validator.Validate(email);
                if (result.IsValid)
                {
                    _webService.Insert(email);
                    MessageBox.Show("Сообщение зарегитрированно!");
                    this.Close();
                }
                else
                {
                    foreach (var failure in result.Errors)
                    {
                        _logger.Error("Property " + failure.PropertyName + " failed validation.Error was: " + failure.ErrorMessage);
                    }
                    MessageBox.Show("Заполните все поля");
                }
            };
        }
    }
}
