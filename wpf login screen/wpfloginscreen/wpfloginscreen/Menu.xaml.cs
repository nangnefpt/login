using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace wpfloginscreen
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-RPUSVGS;Initial Catalog=a1;Integrated Security=True;");
     
        private void product_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                SqlCommand cmd;
                SqlDataAdapter adt;
                DataTable dt = new DataTable();
                sqlCon.Open();
                cmd = new SqlCommand("select * from Products", sqlCon);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView.ItemsSource = dt.DefaultView; // Sử dụng ItemsSource thay vì DataSource                sqlCon.Close();
                sqlCon.Close();
            } catch { }

        }

        private void catagori_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlDataAdapter adt;
                DataTable dt = new DataTable();
                sqlCon.Open();
                cmd = new SqlCommand("select * from Categories", sqlCon);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView1.ItemsSource = dt.DefaultView; // Sử dụng ItemsSource thay vì DataSource                sqlCon.Close();
                sqlCon.Close();
            }
            catch { }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void account_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlCommand cmd;
                SqlDataAdapter adt;
                DataTable dt = new DataTable();
                sqlCon.Open();
                cmd = new SqlCommand("select * from Accounts", sqlCon);
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dataGridView2.ItemsSource = dt.DefaultView; // Sử dụng ItemsSource thay vì DataSource                sqlCon.Close();
                sqlCon.Close();
            }
            catch { }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
