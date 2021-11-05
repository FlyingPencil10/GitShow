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
using Decision_Color;
using MiscClasses;


namespace Beginning
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

        /// <summary>
        /// Connects to the Decision Color Project
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decision_Color(object sender, RoutedEventArgs e)
        {
            new Decision_Color.MainWindow().Show();       
        }

        private void VariableDisplay(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Variable.Words + " " + Variable.Numbers.ToString());
            string converter = Variable.Numbers.ToString();
            int converted = int.Parse(converter);
            MessageBox.Show("The original number has been converted to a string and back: " + converted.ToString());
        }
    }
}
