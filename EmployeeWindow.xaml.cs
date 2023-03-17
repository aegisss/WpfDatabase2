using Database.MagazineDataSetTableAdapters;
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
using System.Windows.Shapes;

namespace Database
{
    public partial class EmployeeWindow : Window
    {
        EmployeeTableAdapter adapter1 = new EmployeeTableAdapter();
        PostTableAdapter adapter2 = new PostTableAdapter();
        RangTableAdapter adapter3 = new RangTableAdapter();
        int FK1 = 0;
        int FK2 = 0;
        public EmployeeWindow()
        {
            InitializeComponent();
            EmployeeDataGrid.ItemsSource = adapter1.GetData();
            FKRef.ItemsSource = adapter3.GetData();
            FKRef.DisplayMemberPath = "Title";
            FKRef1.ItemsSource = adapter2.GetData();
            FKRef1.DisplayMemberPath = "Post_code";
        }


        private void FKRef_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (FKRef.SelectedItem as DataRowView).Row[0];
            FK1 = (int)cell;

        }

        private void FKRef1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (FKRef1.SelectedItem as DataRowView).Row[0];
            FK2 = (int)cell;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            adapter1.InsertEmployee(NameText.Text, NameText1.Text, NameText2.Text, NameText3.Text, FK1, FK2);
            EmployeeDataGrid.ItemsSource = adapter1.GetData();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
