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
    
    public partial class AdminRoomsPage : Page
    {
        public AdminRoomsPage()
        {
            InitializeComponent();
        }
        //нужно, чтобы таблицы номеров 4х отелей из базы данных выводились на странице приложения

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LUJO_BODRUM.ItemsSource = TravelHubEntities.GetContext().LUJO_BODRUM.ToList();
            MAXX_ROYAL_BELEK_GOLF_RESORT.ItemsSource = TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.ToList();
            STEIGENBERGER_ALCAZAR.ItemsSource = TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.ToList();
            VOYAGE_SORGUN.ItemsSource = TravelHubEntities.GetContext().VOYAGE_SORGUN.ToList();


        }

        //описание кнопки редактирования для таблиц
        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            LUJO_BODRUM.IsReadOnly = false;
            LUJO_BODRUM.BeginEdit();
            MAXX_ROYAL_BELEK_GOLF_RESORT.IsReadOnly = false;
            MAXX_ROYAL_BELEK_GOLF_RESORT.BeginEdit();
            STEIGENBERGER_ALCAZAR.IsReadOnly = false;
            STEIGENBERGER_ALCAZAR.BeginEdit();
            VOYAGE_SORGUN.IsReadOnly = false;
            VOYAGE_SORGUN.BeginEdit();

        }
        //описание кнопки сохранения для таблиц

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TravelHubEntities.GetContext().SaveChanges();
            LUJO_BODRUM.IsReadOnly = true;
            LUJO_BODRUM.UpdateLayout();
            MAXX_ROYAL_BELEK_GOLF_RESORT.IsReadOnly = true;
            MAXX_ROYAL_BELEK_GOLF_RESORT.UpdateLayout();
            STEIGENBERGER_ALCAZAR.IsReadOnly = true;
            STEIGENBERGER_ALCAZAR.UpdateLayout();
            VOYAGE_SORGUN.IsReadOnly = true;
            VOYAGE_SORGUN.UpdateLayout();

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add());

        }
        //описание кнопки удаления для таблиц с всплывающим предупреждением пользователя об удалении

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить комнату в гостинице №1?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var agr = LUJO_BODRUM.SelectedItem as LUJO_BODRUM;

                TravelHubEntities.GetContext().LUJO_BODRUM.Remove(agr);
                TravelHubEntities.GetContext().SaveChanges();
                LUJO_BODRUM.ItemsSource = TravelHubEntities.GetContext().LUJO_BODRUM.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }
            if (MessageBox.Show("Вы действительно хотите удалить комнату в гостинице №2?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var agr1 = MAXX_ROYAL_BELEK_GOLF_RESORT.SelectedItem as MAXX_ROYAL_BELEK_GOLF_RESORT;
                TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.Remove(agr1);
                TravelHubEntities.GetContext().SaveChanges();
                MAXX_ROYAL_BELEK_GOLF_RESORT.ItemsSource = TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");

            }
            if (MessageBox.Show("Вы действительно хотите удалить комнату в гостинице №3?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var agr2 = STEIGENBERGER_ALCAZAR.SelectedItem as STEIGENBERGER_ALCAZAR;
                TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.Remove(agr2);
                TravelHubEntities.GetContext().SaveChanges();
                STEIGENBERGER_ALCAZAR.ItemsSource = TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }
            if (MessageBox.Show("Вы действительно хотите удалить комнату в гостинице №4?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var agr3 = VOYAGE_SORGUN.SelectedItem as VOYAGE_SORGUN;
                TravelHubEntities.GetContext().VOYAGE_SORGUN.Remove(agr3);
                TravelHubEntities.GetContext().SaveChanges();
                VOYAGE_SORGUN.ItemsSource = TravelHubEntities.GetContext().VOYAGE_SORGUN.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }

        }
    }
}
