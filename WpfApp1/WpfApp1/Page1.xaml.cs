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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) ///Login button sends you to home page
        {
            this.NavigationService.Navigate(new Page4());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) ///Registration button goes to registration page
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) ///Remove later, next button
        {
            this.NavigationService.Navigate(new Page2());
        }
    }
}
