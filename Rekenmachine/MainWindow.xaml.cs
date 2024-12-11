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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rekenmachine
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = Convert.ToDouble(getal1TextBox.Text);
            double getal2 = Convert.ToDouble(getal2TextBox.Text);
            resultaatTextBox.Text = (getal1 + getal2).ToString();


        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            double getal1=Convert.ToDouble(getal1TextBox.Text);
            double getal2 =Convert.ToDouble(getal2TextBox.Text);    
            resultaatTextBox.Text= (getal1 * getal2).ToString();    

        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            double getal1 = Convert.ToDouble(getal1TextBox.Text);
            double getal2 = Convert.ToDouble (getal2TextBox.Text);
            resultaatTextBox.Text=(getal1 - getal2).ToString();
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            double getal1=Convert.ToDouble (getal1TextBox.Text);
            double getal2=Convert.ToDouble(getal2TextBox.Text);
            resultaatTextBox.Text =(getal1 / getal2).ToString();
        }

        private void resultaatTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            getal1TextBox.Clear();
            getal2TextBox.Clear();
            resultaatTextBox.Clear();
        }

        private void afsluitenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void optellenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (optellenMenuItem.IsChecked ==false)
            {
                addButton.IsEnabled = false;

            }
            else
            {
                addButton.IsEnabled = true;

            }


        }

        private void aftrekkenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (aftrekkenMenuItem.IsChecked == false)
            {
                minusButton.IsEnabled = false;

            }
            else
            {
                minusButton.IsEnabled = true;

            }

        }

        private void vermigvuldigingMenuItem_Click(object sender, RoutedEventArgs e)
        {

            if (vermigvuldigingMenuItem.IsChecked == false)
            {
                multiplyButton.IsEnabled = false;

            }
            else
            {
                multiplyButton.IsEnabled = true;

            }

        }

        private void delingMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (delingMenuItem.IsChecked == false)
            {
                divideButton.IsEnabled = false;

            }
            else
            {
                divideButton.IsEnabled = true;

            }

        }
    }
}
