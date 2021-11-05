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

namespace Decision_Color
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



        private void paintBelow(object sender, RoutedEventArgs e)
        {
            if (Number.Text == "1")
            {
                Decision.Content = "Please Pick Number R for a Red Canvas or Number B for Blue Canvas. Anything else will change the canvas white.";
                Ifstatement();
            }
            else if (Number.Text == "2")
            {
                Decision.Content = "Please Pick Number G for a Green Canvas or Number O for Orange Canvas. Anything else will change the canvas white.";
                Switcher();
            }
            else
            {
                Decision.Content = "Please Pick Number R for a Red Canvas or Number B for Blue Canvas. Anything else will change the canvas white.";
                MessageBox.Show("Please Select 1 for an if statement and 2 for a switch statement");
            }
        }

        private void Ifstatement()
        {

            if (Letter.Text == "R" || Letter.Text == "r")
            {
                Ted.Background = new SolidColorBrush(Colors.Red);
            }
            else if (Letter.Text == "B" || Letter.Text == "b")
            {
                Ted.Background = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                MessageBox.Show("An Invalid Selection was entered.  The screen has been set to White.  Please Enter an R for Red or B for Blue");
                Ted.Background = new SolidColorBrush(Colors.White);
            }
        }

        private void Switcher()
        {

            switch (Letter.Text)
            {
                case "G":
                    Ted.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "g":
                    Ted.Background = new SolidColorBrush(Colors.Green);
                    break;
                case "O":
                    Ted.Background = new SolidColorBrush(Colors.Orange);
                    break;
                case "o":
                    Ted.Background = new SolidColorBrush(Colors.Orange);
                    break;
                default:
                    MessageBox.Show("An Invalid Selection was entered.  The screen has been set to White.  Please Enter an G for Green or O for Orange");
                    Ted.Background = new SolidColorBrush(Colors.White);
                    break;
            }
        }
    }
}
