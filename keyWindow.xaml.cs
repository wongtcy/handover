using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Linq;

namespace Handover
{
    /// <summary>
    /// Interaction logic for keyWindow.xaml
    /// </summary>
    public partial class keyWindow : Window
    {
        public keyWindow()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            Labelassignmentdate.Content = System.DateTime.Today.ToString("yyyy-MM-dd");

            string str = string.Concat(Enumerable.Repeat(" ", 3));
            //LabelSignature.Content = string.Concat("Signature" , str ,"Dummy Owner");
        }


        private void Sliderkeymaindoor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxmaindoor.Text = (Math.Round(Sliderkeymaindoor.Value,0)).ToString();

        }

        private void Sliderkeylivingroom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxlivingroom.Text = (Math.Round(Sliderkeylivingroom.Value, 0)).ToString();

        }

        private void Sliderkeykitchen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxkitchen.Text = (Math.Round(Sliderkeykitchen.Value, 0)).ToString();

        }

        private void Sliderkeystorageroom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxstorageroom.Text = (Math.Round(Sliderkeystorageroom.Value, 0)).ToString();

        }

        private void Sliderkeybedroom1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxbedroom1.Text = (Math.Round(Sliderkeybedroom1.Value,0)).ToString();
        }

        private void Sliderkeybedroom2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxbedroom2.Text = (Math.Round(Sliderkeybedroom2.Value,0)).ToString();
        }

        private void Sliderkeybedroom3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxbedroom3.Text = (Math.Round(Sliderkeybedroom3.Value,0)).ToString();
        }

        private void Sliderkeybedroom4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxbedroom4.Text = (Math.Round(Sliderkeybedroom4.Value,0)).ToString();
        }

        private void Sliderkeyworkerroom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxworkerroom.Text = (Math.Round(Sliderkeyworkerroom.Value, 0)).ToString();

        }

        private void Sliderkeywindow_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxwindow.Text = (Math.Round(Sliderkeywindow.Value, 0)).ToString();

        }

        private void Sliderkeymailbox_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxmailbox.Text = (Math.Round(Sliderkeymailbox.Value, 0)).ToString();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sliderfreezer_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxfreezer.Text = (Math.Round(Sliderfreezer.Value, 0)).ToString();

        }

        private void Sliderwashingmachine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxwashingmachine.Text = (Math.Round(Sliderwashingmachine.Value, 0)).ToString();

        }

        private void Sliderairconditioner_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxairconditioner.Text = (Math.Round(Sliderairconditioner.Value, 0)).ToString();

        }

        private void Slidermicrowaveoven_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxmicrowaveoven.Text = (Math.Round(Slidermicrowaveoven.Value, 0)).ToString();

        }

        private void Sliderfan_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxfan.Text = (Math.Round(Sliderfan.Value, 0)).ToString();
        }

        private void Sliderdishwashingmachine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxdishwashingmachine.Text = (Math.Round(Sliderdishwashingmachine.Value, 0)).ToString();
        }

        private void Slideroven_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxoven.Text = (Math.Round(Slideroven.Value, 0)).ToString();
        }

        private void Sliderdehumidifier_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxdehumidifier.Text = (Math.Round(Sliderdehumidifier.Value, 0)).ToString();
        }

        private void Sliderventilationfan_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxventilationfan.Text = (Math.Round(Sliderventilationfan.Value, 0)).ToString();

        }

        private void Slidersofa_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxsofa.Text = (Math.Round(Slidersofa.Value, 0)).ToString();

        }

        private void Slidertable_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Textboxtable.Text = (Math.Round(Slidertable.Value, 0)).ToString();

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
