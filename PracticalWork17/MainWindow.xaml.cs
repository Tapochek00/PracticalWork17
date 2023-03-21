using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        AccountingEntities1 db = AccountingEntities1.GetContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Загружаем таблицу из БД
            db.Accounting.Load();
            //Загружаем таблицу в DataGrid с отслеживанием изменения контекста
            DataGrid.ItemsSource = db.Accounting.Local.ToBindingList();
        }

        
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Owner = this;
            add.ShowDialog();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    db.Accounting.Remove(row);
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
            SearchWindow s = new SearchWindow();
            s.Owner = this;
            s.ShowDialog();

            for (int i = 0; i < DataGrid.Items.Count; i++)
            {
                var row = (Accounting)DataGrid.Items[i];
                string findContent = null;
                if (Data.setSearch == "Фамилия") findContent = row.Surname;
                else if (Data.setSearch == "Имя") findContent = row.Name;
                else if (Data.setSearch == "Отчество") findContent = row.Patronymic;
                else if (Data.setSearch == "Название цеха") findContent = row.WorkshopName;
                else if (Data.setSearch == "Тип изделия") findContent = row.ProductType;
                try
                {
                    if (findContent != null && findContent.Contains(Data.searchText))
                    {
                        object item = DataGrid.Items[i];
                        DataGrid.SelectedItem = item;
                        DataGrid.ScrollIntoView(item);
                        DataGrid.Focus();
                        break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        List<Accounting> _accounting;
        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            FilterWindow filt = new FilterWindow();
            filt.Owner = this;
            filt.ShowDialog();

            try
            {
                _accounting = db.Accounting.ToList();
                var filtered = _accounting.Where(_accounting => _accounting.Surname.Contains(Data.filterText));
                if (Data.setFilter == "Фамилия")
                    filtered = _accounting.Where(_accounting => _accounting.Surname.Contains(Data.filterText));
                else if (Data.setFilter == "Имя")
                    filtered = _accounting.Where(_accounting => _accounting.Name.Contains(Data.filterText));
                else if (Data.setFilter == "Отчество")
                    filtered = _accounting.Where(_accounting => _accounting.Patronymic.Contains(Data.filterText));
                else if (Data.setFilter == "Название цеха")
                    filtered = _accounting.Where(_accounting => _accounting.WorkshopName.Contains(Data.filterText));
                else if (Data.setFilter == "Тип изделия")
                    filtered = _accounting.Where(_accounting => _accounting.ProductType.Contains(Data.filterText));
                else filtered = null;

                DataGrid.ItemsSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = db.Accounting.Local.ToBindingList();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа № 17 - Создание приложения с БД\n\nВариант 14\n\n" +
                "Учет изделий, собранных в цехе за неделю. База данных должна содержать следующую " +
                "информацию: фамилию, имя, отчество сборщика, количество изготовленных изделий за " +
                "каждый день недели раздельно, название цеха, а также тип изделия и его стоимость. " +
                "\n\nвыполнила Дунаева М.И. группа ИСП-31");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
