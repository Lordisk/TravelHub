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

namespace TravelHub
{
    /// <summary>
    /// Логика взаимодействия для AdminHotelPage.xaml
    /// </summary>
    public partial class AdminHotelPage : Page
    {
        public AdminHotelPage()
        {
            InitializeComponent();
        }

        private void LUJO_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminRoom1Page());
        }

        private void MAXX_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminRoom2Page());

        }

        private void STEIG_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminRoom3Page());

        }

        private void VOYAGE_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminRoom4Page());

        }
    }
}
