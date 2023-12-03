﻿using System;
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
    /// Логика взаимодействия для Room2Page.xaml
    /// </summary>
    public partial class Room2Page : Page
    {
        public Room2Page()
        {
            InitializeComponent();
            //выводится имя и отчесво пользователя
            RoomsListView.ItemsSource = TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.ToList();
            if (UserInfo.Login != null)
            {
                userNameBox.Content = UserInfo.Name + " " + UserInfo.Surname + " " + UserInfo.SecondName;
            }
            else
            {
                userNameBox.Content = "Неавторизованный пользователь";
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var current = (MAXX_ROYAL_BELEK_GOLF_RESORT)RoomsListView.SelectedItem;
            BasketClass.addProduct((int)current.idRoom);
            this.checkBasketCount();
        }

        private void checkBasketCount()
        {
            btnEnterBasket.Visibility = Visibility.Hidden;
            if (BasketClass.getBasket().Count > 0)
            {
                btnEnterBasket.Visibility = Visibility.Visible;
            }
        }




        private void RoomSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            RoomsListView.ItemsSource = TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.Where(u => u.NameRoom.Contains(RoomSearch.Text)).ToList();

        }

        private void EnterBasket_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BasketPage());
        }

        

        private void userNameBox_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (UserInfo.Login != "0")
            {
                NavigationService.Navigate(new BasketPage());
            }
            else
            {
                MessageBox.Show("Авторизируйтесь в приложении и сделайте заказ, чтобы увидеть список ваших заказов");
                return;
            }
        }
    }
}
