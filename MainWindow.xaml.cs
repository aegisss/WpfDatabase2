using System;
using System.Collections.Generic;
using System.Data;
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
using Database.MagazineDataSetTableAdapters;
namespace Database
{
    public partial class MainWindow : Window
    {
        RangTableAdapter adapter = new RangTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            RangDataGrid.ItemsSource = adapter.GetData();
        }
//Добавление данных в таблицу
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            adapter.Insert1(NameTbx.Text, NameTbx1.Text, NameTbx2.Text);
            RangDataGrid.ItemsSource = adapter.GetData();
        }
//Переход в другое окно
        private void GoToNext_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow window = new EmployeeWindow();
            window.Show();
            this.Close();
        }
    }
}
