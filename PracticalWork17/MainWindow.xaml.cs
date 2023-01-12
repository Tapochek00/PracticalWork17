﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticalWork17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Получаем доступ к контексту данных
        AccountingEntities db = AccountingEntities.GetContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Загружаем таблицу из БД
            db.Accountings.Load();
            //Загружаем таблицу в DataGrid с отслеживанием изменения контекста
            DataGrid.ItemsSource = db.Accountings.Local.ToBindingList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}