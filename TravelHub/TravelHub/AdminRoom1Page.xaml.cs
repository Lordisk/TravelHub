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
    
    public partial class AdminRoom1Page : Page
    {
        public AdminRoom1Page()
        {
            InitializeComponent();
        }
        //нужно, чтобы таблица из базы данных выводилась на странице приложения
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LUJO_BODRUM.ItemsSource = TravelHubEntities.GetContext().LUJO_BODRUM.ToList();
        }


        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            LUJO_BODRUM.IsReadOnly = false;
            LUJO_BODRUM.BeginEdit();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TravelHubEntities.GetContext().SaveChanges();
            LUJO_BODRUM.IsReadOnly = true;
            LUJO_BODRUM.UpdateLayout();

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add());

        }
        //описание кнопки удаления с всплывающим предупреждением пользователя об удалении
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить комнату?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var agr = LUJO_BODRUM.SelectedItem as LUJO_BODRUM;
                TravelHubEntities.GetContext().LUJO_BODRUM.Remove(agr);
                TravelHubEntities.GetContext().SaveChanges();
                LUJO_BODRUM.ItemsSource = TravelHubEntities.GetContext().LUJO_BODRUM.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }
        }
    }
}
