using EmailRegistrationUi.EmailRegistrationWebService;
using EmailRegistrationUi.Services.Validator;
using Ninject;
using NLog;
using System.Windows;

namespace EmailRegistrationUi.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView(IKernel kernel, WebService _webService, EmailValidator _validator, Logger _logger)
        {
            InitializeComponent();
            
            // Обработчик события нажатия кнопки "регистрации нового письма".
            // Открывает окно регистрации нового письма
            btnAddNewEmail.Click += (s, e) =>
            {
                AddNewEmailView anev = new AddNewEmailView(kernel, _webService, _validator, _logger);
                anev.Owner = this;
                anev.ShowDialog();
            };

            // Обработчик события нажатия кнопки "показать все письма".
            // Открывает окно для отображения писем
            btnShowAllEmail.Click += (s, e) =>
            {
                ShowAllEmailView saev = new ShowAllEmailView(kernel, _webService, _validator, _logger);
                saev.Owner = this;
                saev.ShowDialog();
            };
        }
    }
}
