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
    /// Interaction logic for Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }

        private void MessageBackButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page11());
        }

        private void ProfileButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5()); ///This takes you to the profile page
        }

        private void RideButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page9()); ///This takes you to the MyPools ride page
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4()); ///This takes you to the home page
        }
    }
}
