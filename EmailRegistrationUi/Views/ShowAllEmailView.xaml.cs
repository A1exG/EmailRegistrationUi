﻿using EmailRegistrationUi.EmailRegistrationWebService;
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

            // Обработчик события загрузки dataGrid
            // Запрашивает с web servera все зарегистрированные письма и выводит их в dataGrid
            dgEmails.Loaded += (s, e) =>
            {
                if(btnAllEmails.IsChecked == true)
                {
                    var ItemsSource = _webService.GetAllEmails();
                    dgEmails.ItemsSource = ItemsSource;
                    DataGridCol();
                }
            };

            // Обработчик события нажатия на кнопку "все письма"
            btnAllEmails.Click += (s, e) =>
            {
                txtSerchId.Visibility = Visibility.Hidden;
                UpdateData();
            };

            // Обработчик события нажатия на кнопку "поиск по Id"
            btnSerchId.Click += (s, e) =>
            {
                txtSerchId.Visibility = Visibility.Visible;
                txtSerchId.Text = "";
            };

            // Обработчик события изменения Id в строке поиска и отображение результата в dataGrid
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

            // Обработчик события нажатия кнопки "закрыть"  
            // Закрывает текущее окно
            btnClose.Click += (s, e) =>
            {
                this.Close();
            };

            // Обработчик события нажатия кнопки "отменить"  
            btnCanlse.Click += (s, e) =>
            {
                gridEdit.Visibility = Visibility.Hidden;
                btnSaveChanges.Visibility = Visibility.Hidden;
                btnCanlse.Visibility = Visibility.Hidden;
                btnClose.Visibility = Visibility.Visible;
            };

            // Обработчик события нажатия кнопки "сохранить"  
            // Сохрание изменений, внесенных пользователев в зарегистрированное письмо
            // После сохранения обновление данных в dataGrid
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

        // Запрашивает с web servera все зарегистрированные письма и выводит их в dataGrid
        private void UpdateData()
        {
            var ItemsSource = _webService.GetAllEmails();
            dgEmails.ItemsSource = ItemsSource;
        }

        // Переименовывает столбцы в dataGrid
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

        // Обработчик события клика в dataGrid на ячейку для получения данных 
        // После нажатия на ячейку, выделяется строка и данные копируются в текстбоксы для редактирования.
        // 
        
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

        // Проверка поля для поиска на ввод только цифр
        private void txtSerchId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string inputSymbol = e.Text.ToString();

            if (!Regex.Match(inputSymbol, @"[0-9]").Success)
            {
                e.Handled = true;
            }
        }
    }
}
