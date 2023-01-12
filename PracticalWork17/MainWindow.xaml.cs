using System;
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
            Add add = new Add();
            add.Owner = this;
            add.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            int indexRow = DataGrid.SelectedIndex;
            if (indexRow != -1)
            {
                Accounting row = (Accounting)DataGrid.Items[indexRow];
                Data.Id = row.id;
                EditRecord edit = new EditRecord();
                edit.Owner = this;
                edit.ShowDialog();
                DataGrid.Items.Refresh();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Удалить запись?", "Удаление записи",
                MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Accounting row = (Accounting)DataGrid.SelectedItems[0];
                    db.Accountings.Remove(row);
                    db.SaveChanges();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите запись");
                }
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow s = new SearchWindow;
            s.Owner = this;
            s.ShowDialog();

            for (int i = 0; i < DataGrid.Items.Count; i++)
            {
                var row = (Accounting)DataGrid.Items[i];
                string findContent = "";
            }
        }
    }
}
