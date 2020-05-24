using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmailRegistrationUi.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView(IKernel kernel)
        {
            InitializeComponent();

            btnAddNewEmail.Click += (s, e) =>
            {
                AddNewEmailView anev = new AddNewEmailView(kernel);
                anev.Owner = this;
                anev.ShowDialog();
            };

            btnShowAllEmail.Click += (s, e) =>
            {
                ShowAllEmailView saev = new ShowAllEmailView(kernel);
                saev.Owner = this;
                saev.ShowDialog();
            };

            btnShowEmailInId.Click += (s, e) =>
            {
                ShowEmailInIdView seiv = new ShowEmailInIdView(kernel);
                seiv.Owner = this;
                seiv.ShowDialog();
            };
        }
    }
}
