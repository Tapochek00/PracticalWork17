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
    /// Логика взаимодействия для EditRecord.xaml
    /// </summary>
    public partial class EditRecord : Window
    {
        public EditRecord()
        {
            InitializeComponent();
        }

        AccountingEntities1 db = AccountingEntities1.GetContext();
        Accounting acc;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            acc = db.Accounting.Find(Data.Id);

            Surname.Text = acc.Surname;
            Namee.Text = acc.Name;
            Patronymic.Text = acc.Patronymic;
            mon.Text = acc.QuantityMon.ToString();
            tue.Text = acc.QuantityTue.ToString();
            wed.Text = acc.QuantityWed.ToString();
            thu.Text = acc.QuantityThu.ToString();
            fri.Text = acc.QuantityFri.ToString();
            sat.Text = acc.QuantitySat.ToString();
            sun.Text = acc.QuantitySun.ToString();
            WorkshopName.Text = acc.WorkshopName;
            ProductType.Text = acc.ProductType;
            Cost.Text = acc.Cost.ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (mon.Text.Length == 0) mon.Text = "0";
            if (tue.Text.Length == 0) tue.Text = "0";
            if (wed.Text.Length == 0) wed.Text = "0";
            if (thu.Text.Length == 0) thu.Text = "0";
            if (fri.Text.Length == 0) fri.Text = "0";
            if (sat.Text.Length == 0) sat.Text = "0";
            if (sun.Text.Length == 0) sun.Text = "0";

            StringBuilder errors = new StringBuilder();
            if (Surname.Text.Length == 0) errors.AppendLine("Введите фамилию");
            if (Namee.Text.Length == 0) errors.AppendLine("Введите имя");
            if (WorkshopName.Text.Length == 0) errors.AppendLine("Введите название цеха");
            if (ProductType.Text.Length == 0) errors.AppendLine("Введите тип изделия");
            if (Cost.Text.Length == 0 || !double.TryParse(Cost.Text, out double cost)) errors.AppendLine("Введите правильную стоимость изделия");
            if (!int.TryParse(mon.Text, out int y) ||
                !int.TryParse(tue.Text, out y) ||
                !int.TryParse(wed.Text, out y) ||
                !int.TryParse(thu.Text, out y) ||
                !int.TryParse(fri.Text, out y) ||
                !int.TryParse(sat.Text, out y) ||
                !int.TryParse(sun.Text, out y)
                ) errors.AppendLine("Введите правильное количество");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            acc.Surname = Surname.Text;
            acc.Name = Namee.Text;
            acc.Patronymic = Patronymic.Text;
            acc.QuantityMon = Convert.ToInt32(mon.Text);
            acc.QuantityTue = Convert.ToInt32(tue.Text);
            acc.QuantityWed = Convert.ToInt32(wed.Text);
            acc.QuantityThu = Convert.ToInt32(thu.Text);
            acc.QuantityFri = Convert.ToInt32(fri.Text);
            acc.QuantitySat = Convert.ToInt32(sat.Text);
            acc.QuantitySun = Convert.ToInt32(sun.Text);
            acc.WorkshopName = WorkshopName.Text;
            acc.ProductType = ProductType.Text;
            acc.Cost = Convert.ToDouble(Cost.Text);

            try
            {
                db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
