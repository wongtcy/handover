using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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
            setTimer();
        }

        private void setTimer()
        {
            //DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            //dispatcherTimer.Tick += dispatcherTimer_Tick;
            //dispatcherTimer.Interval = TimeSpan.FromSeconds(10);
            //dispatcherTimer.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text.Trim().Length == 10)
            {
                keyWindow keywin = new keyWindow();
                keywin.Show();
            }
            else 
            {
                MessageBox.Show("Please input the property account code!", "REMINDER", MessageBoxButton.OK);
            }
        }
    }
}
