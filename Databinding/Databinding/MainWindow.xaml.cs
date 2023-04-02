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

namespace Databinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //If wanted to use OneTime(on initialization) data binding need to write some extra code

            //MySlider.Value = 30;
            //MyTextBox.Text = MySlider.Value.ToString();

            //This code would set the value to 30 upon Start Up

            
        }

        private void ColourTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.ToString();
        }
    }
}
