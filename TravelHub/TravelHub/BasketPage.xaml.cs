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
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        private List<LUJO_BODRUM> basketItems = new List<LUJO_BODRUM>();
        private List<MAXX_ROYAL_BELEK_GOLF_RESORT> basketItems1 = new List<MAXX_ROYAL_BELEK_GOLF_RESORT>();
        private List<STEIGENBERGER_ALCAZAR> basketItems2 = new List<STEIGENBERGER_ALCAZAR>();
        private List<VOYAGE_SORGUN> basketItems3 = new List<VOYAGE_SORGUN>();

        public BasketPage()
        {
            InitializeComponent();
            //создание basketItems с разными индексами, для каждой отдельной таблицы комнат из баз данных
            basketItems = new List<LUJO_BODRUM>();
            foreach (int id in BasketClass.getBasket())
            {
                basketItems.Add(TravelHubEntities.GetContext().LUJO_BODRUM.Find(id));
            }
            BasketListView.ItemsSource = basketItems;
            updateItog();

            basketItems1 = new List<MAXX_ROYAL_BELEK_GOLF_RESORT>();
            foreach (int id in BasketClass.getBasket())
            {
                basketItems1.Add(TravelHubEntities.GetContext().MAXX_ROYAL_BELEK_GOLF_RESORT.Find(id));
            }
            BasketListView.ItemsSource = basketItems1;
            updateItog();

            basketItems2 = new List<STEIGENBERGER_ALCAZAR>();
            foreach (int id in BasketClass.getBasket())
            {
                basketItems2.Add(TravelHubEntities.GetContext().STEIGENBERGER_ALCAZAR.Find(id));
            }
            BasketListView.ItemsSource = basketItems2;
            updateItog();

            basketItems3 = new List<VOYAGE_SORGUN>();
            foreach (int id in BasketClass.getBasket())
            {
                basketItems3.Add(TravelHubEntities.GetContext().VOYAGE_SORGUN.Find(id));
            }
            BasketListView.ItemsSource = basketItems3;
            updateItog();
        }
        private void updateItog()
        {
            
        }
        //оформление заказа, неавторизованный гость не может бронировать
        private void MakeZakaz_Click(object sender, RoutedEventArgs e)
        {
            if (UserInfo.Login != "")
            {
                if (MessageBox.Show($"Вы точно хотите забронировать номер?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {

                    try
                    {
                        TravelHubEntities.GetContext().SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    MessageBox.Show("Номер забронирован! Ожидайте сообщения на почту");
                    NavigationService.Navigate(new CongratulationPage());
                }
            }
            else
            {
                MessageBox.Show("Необходимо авторизоваться");
                return;
            }
            
        }
        //пустой класс, что бы не было ошибок
        private void Dni_TextChanged(object sender, RoutedEventArgs e)
        { 
        }
        //вывод итоговой суммы исходя из цены комнаты за 1 сутки и вводимых гостем дней проживания 
        private void NewSuum_Click(object sender, RoutedEventArgs e)
        {
            if (Dni == null)
            {
                Itog.Content = $"Итого:{basketItems.Sum(product => product.Price1day)}";
                Itog.Content = $"Итого:{basketItems1.Sum(product => product.Price1day)}";
                Itog.Content = $"Итого:{basketItems2.Sum(product => product.Price1day)}";
                Itog.Content = $"Итого:{basketItems3.Sum(product => product.Price1day)}";

            }
            else
            {
                var summ = basketItems.Sum(product => product.Price1day);
                var summ1 = summ * Convert.ToDecimal(Dni.Text);
                Itog.Content = $"Итого:{summ1}";

                var summM = basketItems1.Sum(product => product.Price1day);
                var summ1M = summM * Convert.ToDecimal(Dni.Text);
                Itog.Content = $"Итого:{summ1M}";

                var summS = basketItems2.Sum(product => product.Price1day);
                var summ1S = summS * Convert.ToDecimal(Dni.Text);
                Itog.Content = $"Итого:{summ1S}";

                var summV = basketItems3.Sum(product => product.Price1day);
                var summ1V = summV * Convert.ToDecimal(Dni.Text);
                Itog.Content = $"Итого:{summ1V}";


            }

        }
    }
}
