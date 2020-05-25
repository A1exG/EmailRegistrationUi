using EmailRegistrationUi.EmailRegistrationWebService;
using EmailRegistrationUi.Services.Validator;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace EmailRegistrationUi.Views
{
    public partial class ShowAllEmailView : Window
    {
        private WebService _webService;
        public ShowAllEmailView(IKernel kernel)
        {
            InitializeComponent();
            var webService = kernel.Get<WebService>();
            var validator = kernel.Get<Validator>();
            _webService = webService;

            dgEmails.Loaded += (s, e) =>
            {
                if(btnAllEmails.IsChecked == true)
                {
                    var ItemsSource = _webService.GetAllEmails();
                    dgEmails.ItemsSource = ItemsSource;
                    DataGridCol();
                }
            };

            btnAllEmails.Click += (s, e) =>
            {
                txtSerchId.Visibility = Visibility.Hidden;
                UpdateData();
            };

            btnSerchId.Click += (s, e) =>
            {
                txtSerchId.Visibility = Visibility.Visible;
            };

            txtSerchId.TextChanged += (s, e) =>
            {
                if (validator.CheckStringEmpty(txtSerchId))
                {
                    List<Email> listE = new List<Email>();
                    listE.Add(webService.GetEmailInId(Convert.ToInt32(txtSerchId.Text)));
                    dgEmails.ItemsSource = listE;
                    DataGridCol();
                }
            };

            btnClose.Click += (s, e) =>
            {
                this.Close();
            };

            btnCanlse.Click += (s, e) =>
            {
                gridEdit.Visibility = Visibility.Hidden;

                btnSaveChanges.Visibility = Visibility.Hidden;
                btnCanlse.Visibility = Visibility.Hidden;
                btnClose.Visibility = Visibility.Visible;
            };

            btnSaveChanges.Click += (s, e) =>
            {
                var connect = webService.SaveChangeEmail(Convert.ToInt32(txtEmailId.Text), txtEmailName.Text, dpEmailRegistrationDate.DisplayDate, txtEmailTo.Text, txtEmailFrom.Text, txtEmailTag.Text, txtEmailContent.Text);
                if (connect > 0)
                {
                    MessageBox.Show("Сообщение изменено!");
                    gridEdit.Visibility = Visibility.Hidden;

                    btnSaveChanges.Visibility = Visibility.Hidden;
                    btnCanlse.Visibility = Visibility.Hidden;
                    btnClose.Visibility = Visibility.Visible;

                    UpdateData();
                }
            };

        }

        private void UpdateData()
        {
            var ItemsSource = _webService.GetAllEmails();
            dgEmails.ItemsSource = ItemsSource;
        }

        private void DataGridCol()
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

                gridEdit.Visibility = Visibility.Visible;

                txtEmailId.Text = ((Email)currentIem).EmailId.ToString();
                txtEmailName.Text = ((Email)currentIem).EmailName.ToString();
                dpEmailRegistrationDate.SelectedDate = ((Email)currentIem).EmailRegistrationDate;
                txtEmailTo.Text = ((Email)currentIem).EmailTo.ToString();
                txtEmailFrom.Text = ((Email)currentIem).EmailFrom.ToString();
                txtEmailTag.Text = ((Email)currentIem).EmailTag.ToString();
                txtEmailContent.Text = ((Email)currentIem).EmailContent.ToString();

                btnSaveChanges.Visibility = Visibility.Visible;
                btnCanlse.Visibility = Visibility.Visible;
                btnClose.Visibility = Visibility.Hidden;
            }
        }

        private void txtSerchId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string inputSymbol = e.Text.ToString();

            if (!Regex.Match(inputSymbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }
        }

        private void txtSerchId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
