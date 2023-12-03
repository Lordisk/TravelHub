using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public Add()
        {
            InitializeComponent();
        }
        //описание кнопок добавления комнаты для одного из 4х отелей и сохранения в базу данных
        private void ButtonSave1_Click(object sender, RoutedEventArgs e)
        {
            LUJO_BODRUM Agr = new LUJO_BODRUM();

            Agr.idRoom = Convert.ToInt32(idBox.Text);
            Agr.NameRoom = nameBox.Text;
            Agr.Accessibility = accessBox.Text;
            Agr.People = peopleBox.Text;
            Agr.Price1day = Convert.ToDecimal(priceBox.Text);

            TravelHubEntities.GetContext().LUJO_BODRUM.Add(Agr);
            TravelHubEntities.GetContext().SaveChanges();
            MessageBox.Show("Комната добавлена в систему", "Уведомление");
        }

        private void ButtonSave2_Click(object sender, RoutedEventArgs e)
        {
            MAXX_ROYAL_BELEK_GOLF_RESORT Agr = new MAXX_ROYAL_BELEK_GOLF_RESORT();

            Agr.idRoom = Convert.ToInt32(idBox.Text);
            Agr.NameRoom = nameBox.Text;
            Agr.Accessibility = accessBox.Text;
            Agr.People = peopleBox.Text;
            Agr.Price1day = Convert.ToDecimal(priceBox.Text);

            TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.Add(Agr);
            TravelHubEntities.GetContext().SaveChanges();
            MessageBox.Show("Комната добавлена в систему", "Уведомление");
        }

        private void ButtonSave3_Click(object sender, RoutedEventArgs e)
        {
            STEIGENBERGER_ALCAZAR Agr = new STEIGENBERGER_ALCAZAR();

            Agr.idRoom = Convert.ToInt32(idBox.Text);
            Agr.NameRoom = nameBox.Text;
            Agr.Accessibility = accessBox.Text;
            Agr.People = peopleBox.Text;
            Agr.Price1day = Convert.ToDecimal(priceBox.Text);

            TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.Add(Agr);
            TravelHubEntities.GetContext().SaveChanges();
            MessageBox.Show("Комната добавлена в систему", "Уведомление");
        }

        private void ButtonSave4_Click(object sender, RoutedEventArgs e)
        {
            VOYAGE_SORGUN Agr = new VOYAGE_SORGUN();

            Agr.idRoom = Convert.ToInt32(idBox.Text);
            Agr.NameRoom = nameBox.Text;
            Agr.Accessibility = accessBox.Text;
            Agr.People = peopleBox.Text;
            Agr.Price1day = Convert.ToDecimal(priceBox.Text);

            TravelHubEntities.GetContext().VOYAGE_SORGUN.Add(Agr);
            TravelHubEntities.GetContext().SaveChanges();
            MessageBox.Show("Комната добавлена в систему", "Уведомление");
        }
    }
}
