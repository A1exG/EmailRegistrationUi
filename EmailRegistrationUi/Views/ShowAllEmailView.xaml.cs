using Ninject;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EmailRegistrationUi.Views
{
    public partial class ShowAllEmailView : Window
    {
        public ShowAllEmailView(IKernel kernel)
        {
            InitializeComponent();

            dgEmails.Loaded += (s, e) =>
            {
                var connect = kernel.Get<EmailRegistrationWebService.WebService>();
                var ItemsSource = connect.GetAllEmails();
                dgEmails.ItemsSource = ItemsSource;
                HeadTable();
            };

            btnClose.Click += (s, e) =>
            {
                this.Close();
            };
        }
        public void HeadTable()
        {
            dgEmails.Columns[0].Header = "Id";
            dgEmails.Columns[1].Header = "Название";
            dgEmails.Columns[2].Header = "Дата регистрации";
            dgEmails.Columns[3].Header = "Адресат";
            dgEmails.Columns[4].Header = "Отправитель";
            dgEmails.Columns[5].Header = "Тэг";
            dgEmails.Columns[6].Header = "Содержание";
        }

        private void DataGridCell_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DataGridCell cell = sender as DataGridCell;
            if (!cell.IsEditing)
            {
                if (!cell.IsFocused)
                    cell.Focus();
                if (!cell.IsSelected)
                    cell.IsSelected = true;
            }
        }
        private void dgEmails_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            foreach (var item in e.AddedCells)
            {
                var col = item.Column as DataGridColumn;

                var fc = col.GetCellContent(item.Item);
                var currentIem = dgEmails.CurrentItem;
                var currentCol = dgEmails.CurrentColumn;

                if (fc is TextBlock)
                {
                    var a = (fc as TextBlock).Text;
                }
            }
        }
    }
}
