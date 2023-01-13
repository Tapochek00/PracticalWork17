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

namespace PracticalWork17
{
    /// <summary>
    /// Логика взаимодействия для FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : Window
    {
        public FilterWindow()
        {
            InitializeComponent();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            Data.setFilter = setSearch.Text;
            Data.filterText = searchText.Text;

            this.Close();
        }
    }
}
