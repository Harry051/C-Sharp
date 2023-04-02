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

namespace CheckBox
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

        private void cbAllTopings_Checked(object sender, RoutedEventArgs e)
        {
            bool newValue = cbAllToppings.IsChecked == true;
            cbPepperoni.IsChecked = newValue;
            cbOnions.IsChecked = newValue;
            cbPeppers.IsChecked = newValue;
            cbPineapple.IsChecked = newValue;
            cbHam.IsChecked = newValue;
            cbVeganCheese.IsChecked = newValue;
        }

        private void cbSingle_Checked(object sender, RoutedEventArgs e)
        {
            cbAllToppings.IsChecked = null;
            if((cbPepperoni.IsChecked == true) && (cbOnions.IsChecked == true) && (cbPeppers.IsChecked == true) 
                && (cbPineapple.IsChecked == true) && (cbHam.IsChecked == true) && (cbVeganCheese.IsChecked == true))
            {
                cbAllToppings.IsChecked = true;
            }
            if ((cbPepperoni.IsChecked == false) && (cbOnions.IsChecked == false) && (cbPeppers.IsChecked == false)
                && (cbPineapple.IsChecked == false) && (cbHam.IsChecked == false) && (cbVeganCheese.IsChecked == false))
            {
                cbAllToppings.IsChecked = false;
            }

        }
    }
}
