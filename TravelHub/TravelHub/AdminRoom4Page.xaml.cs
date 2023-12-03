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
    
    public partial class AdminRoom4Page : Page
    {
        public AdminRoom4Page()
        {
            InitializeComponent();
        }
        //нужно, чтобы таблица из базы данных выводилась на странице приложения

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            VOYAGE_SORGUN.ItemsSource = TravelHubEntities.GetContext().VOYAGE_SORGUN.ToList();
        }


        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            VOYAGE_SORGUN.IsReadOnly = false;
            VOYAGE_SORGUN.BeginEdit();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TravelHubEntities.GetContext().SaveChanges();
            VOYAGE_SORGUN.IsReadOnly = true;
            VOYAGE_SORGUN.UpdateLayout();

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
                var agr = VOYAGE_SORGUN.SelectedItem as VOYAGE_SORGUN;
                TravelHubEntities.GetContext().VOYAGE_SORGUN.Remove(agr);
                TravelHubEntities.GetContext().SaveChanges();
                VOYAGE_SORGUN.ItemsSource = TravelHubEntities.GetContext().VOYAGE_SORGUN.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }
        }
    }
}
