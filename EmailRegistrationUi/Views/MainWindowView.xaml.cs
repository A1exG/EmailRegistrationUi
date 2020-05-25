using Ninject;
using System.Windows;

namespace EmailRegistrationUi.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView(IKernel kernel)
        {
            InitializeComponent();
            
            // Обработчик события нажатия кнопки "регистрации нового письма".
            // Открывает окно регистрации нового письма
            btnAddNewEmail.Click += (s, e) =>
            {
                AddNewEmailView anev = new AddNewEmailView(kernel);
                anev.Owner = this;
                anev.ShowDialog();
            };

            // Обработчик события нажатия кнопки "показать все письма".
            // Открывает окно для отображения писем
            btnShowAllEmail.Click += (s, e) =>
            {
                ShowAllEmailView saev = new ShowAllEmailView(kernel);
                saev.Owner = this;
                saev.ShowDialog();
            };
        }
    }
}
