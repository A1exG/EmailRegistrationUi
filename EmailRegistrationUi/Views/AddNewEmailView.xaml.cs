using EmailRegistrationUi.EmailRegistrationWebService;
using EmailRegistrationUi.Services.Validator;
using Ninject;
using System.Windows;

namespace EmailRegistrationUi.Views
{
    public partial class AddNewEmailView : Window
    {
        public AddNewEmailView(IKernel kernel)
        {
            InitializeComponent();
            var EmailRegistrationDate = dpEmailRegistrationDate.DisplayDate.Date;
            var webService = kernel.Get<WebService>();

            // Обработчик события нажатия кнопки "закрыть"  
            // Закрывает текущее окно
            btnClose.Click += (s, e) =>
            {
                this.Close();
            };

            // Обработчик события нажатия кнопки "сохранить"  
            // Проверяет, заполнены ли все поля пользователем. 
            // Если все поля заполнены - отправляет данные на webServer для проверки и дальнейшей регистрации письма в системе
            
            btnSave.Click += (s, e) =>
            {
                Validator validator = kernel.Get<Validator>();

                if (!validator.CheckStringEmpty(txtEmailName))
                {MessageBox.Show("Поле название на заполнено");}
                else if (!validator.CheckDateTimeEmpty(dpEmailRegistrationDate))
                { MessageBox.Show("Поле даты на заполнено"); }
                else if(!validator.CheckStringEmpty(txtEmailTo))
                {MessageBox.Show("Поле адресат на заполнено");}
                else if (!validator.CheckStringEmpty(txtEmailFrom))
                {MessageBox.Show("Поле отправитель на заполнено");}
                else if (!validator.CheckStringEmpty(txtEmailTag))
                {MessageBox.Show("Поле тэг на заполнено");}
                else if (!validator.CheckStringEmpty(txtEmailTag))
                {MessageBox.Show("Поле тэг на заполнено");}
                else if (!validator.CheckStringEmpty(txtEmailContent))
                {MessageBox.Show("Поле сообщение на заполнено");}
                else
                {
                    var connect = webService.AddNewEmail(txtEmailName.Text, EmailRegistrationDate, txtEmailTo.Text, txtEmailFrom.Text, txtEmailTag.Text, txtEmailContent.Text);
                    if (connect > 0)
                    {
                        MessageBox.Show("Сообщение зарегитрированно!");
                        this.Close();
                    }
                }
            };
        }
    }
}
