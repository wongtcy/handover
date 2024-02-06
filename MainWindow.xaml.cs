using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Dapper;

/// Programmer : Tony Wong
/// Date : 2024-01-24
/// Name : MainWindow.xaml
/// Purpose : To provide the main menu
/// Version 1.0

namespace Handover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Loadpremises()
        {
            string connectionString = "Data Source = localhost; Initial Catalog = dbProperty_DEV; user id= sa; password = sa";


            // Retrieve data
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM tblPremises WHERE premisesID = '" + TxtSearch.Text + "'";
                var _premises = conn.Query<premises>(sql).ToList();
                if (_premises.Count == 0)
                {
                    MessageBox.Show("Invalid premises ID!", "REMINDER", MessageBoxButton.OK);
                    return;
                }
                else
                {
                    txtpremisecode.Text = _premises?.ToList().FirstOrDefault().PremisesID;
                    txtaddresseng.Text = _premises?.ToList().FirstOrDefault().ProAddressEng;
                    txtaddresschn.Text = _premises?.ToList().FirstOrDefault().ProAddressChn;
                }
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (TxtSearch.Text.Trim().Length == 10)
            {
                Loadpremises();
            }
            else 
            {
                MessageBox.Show("Please input the property account code!", "REMINDER", MessageBoxButton.OK);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure?","Confirm to exit",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close();
            }

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            keyWindow keywin = new keyWindow();
            keywin.Labelpremisecode.Content = "Premise ID : "+txtpremisecode.Text; 
            keywin.Show();
        }
    }
}
