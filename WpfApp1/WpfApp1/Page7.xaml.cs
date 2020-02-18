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
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page13());
        
        }

        private void NotificationButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page10()); ///This is the notifications popup page from the notifications button
        }

        private void ProfileButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5()); ///This takes you to the profile page
        }

        private void RideButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page7()); ///This takes you to the MyPools ride page
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page4()); ///This takes you to the MyProfile home page
        }
    }
}
