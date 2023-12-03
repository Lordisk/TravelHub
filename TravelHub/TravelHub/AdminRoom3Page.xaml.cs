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
    
    public partial class AdminRoom3Page : Page
    {
        public AdminRoom3Page()
        {
            InitializeComponent();
        }
        //нужно, чтобы таблица из базы данных выводилась на странице приложения

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            STEIGENBERGER_ALCAZAR.ItemsSource = TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.ToList();
        }


        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            STEIGENBERGER_ALCAZAR.IsReadOnly = false;
            STEIGENBERGER_ALCAZAR.BeginEdit();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            TravelHubEntities.GetContext().SaveChanges();
            STEIGENBERGER_ALCAZAR.IsReadOnly = true;
            STEIGENBERGER_ALCAZAR.UpdateLayout();

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
                var agr = STEIGENBERGER_ALCAZAR.SelectedItem as STEIGENBERGER_ALCAZAR;
                TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.Remove(agr);
                TravelHubEntities.GetContext().SaveChanges();
                STEIGENBERGER_ALCAZAR.ItemsSource = TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.ToList();
                MessageBox.Show("Комната удалена", "Уведомление");
            }
        }
    }
}
