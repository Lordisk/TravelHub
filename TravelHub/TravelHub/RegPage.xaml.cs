using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.Xml.Linq;

namespace TravelHub
{
    
    public partial class RegPage : Page
    {
        TravelHubEntities db;
        public RegPage()
        {
            InitializeComponent();
            db = new TravelHubEntities();
        }
        int tries = 0;
        //регистрация пользователя с условиями и обработчиком исключений
        private void ButtonReg_Click(object sender, RoutedEventArgs e)
        {

            Users Agr = new Users();

            //Agr.Login = LoginBox.Text.Trim();
            //Agr.Name = NameBox.Text.Trim();

            //Agr.Surname = SurnameBox.Text.Trim();
            //Agr.Email = EmailBox.Text.Trim();
            //Agr.SecondName = SecondN.Text.Trim();

            //Agr.Password = Parol.Password.Trim();

            if (LoginBox.Text == "")
            {
                LoginBox.ToolTip = "Это поле должно быть заполнено";
                LoginBox.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.Login = LoginBox.Text.Trim(); //trim нужен для того, чтобы данные вводились без пробелов

                LoginBox.ToolTip = "";
                LoginBox.Background = Brushes.Transparent;
            }
            if (SurnameBox.Text == "")
            {
                SurnameBox.ToolTip = "Это поле должно быть заполнено";
                SurnameBox.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.Surname = SurnameBox.Text.Trim();

                SurnameBox.ToolTip = "";
                SurnameBox.Background = Brushes.Transparent;
            }
            if (NameBox.Text == "")
            {
                NameBox.ToolTip = "Это поле должно быть заполнено";
                NameBox.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.Name = NameBox.Text.Trim();

                NameBox.ToolTip = "";

                NameBox.Background = Brushes.Transparent;
            }
            if (SecondN.Text == "")
            {
                SecondN.ToolTip = "Это поле должно быть заполнено";
                SecondN.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.SecondName = SecondN.Text.Trim();

                SecondN.ToolTip = "";
                SecondN.Background = Brushes.Transparent;
            }
            if (!EmailBox.Text.Contains("@") || !EmailBox.Text.Contains("."))
            {
                EmailBox.ToolTip = "Это поле введено некорректно";
                EmailBox.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.Email = EmailBox.Text.Trim();

                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;
            }
            if (Parol.Password.Length < 6)
            {
                Parol.ToolTip = "Это поле введено некорректно";
                Parol.Background = Brushes.DarkRed;
            }
            else
            {
                Agr.Password = Parol.Password.Trim();

                Parol.ToolTip = "";
                Parol.Background = Brushes.Transparent;
            }

            TravelHubEntities.GetContext().Users.Add(Agr);
            //TravelHubEntities.GetContext().SaveChanges();
            MessageBox.Show("Пользователь добавлен в систему", "Уведомление");
            try
            {
                TravelHubEntities.GetContext().SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    MessageBox.Show("Object: " + validationError.Entry.Entity.ToString());
                    MessageBox.Show("");

                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        MessageBox.Show(err.ErrorMessage + "");

                    }
                }
                
            }

        }
        //реализация авторизации пользователя с данными из базы данных, с блокировкой системы на 10 сек за 3 неправильных попыток входа и с разделением по ролям (админ, гость)
        private void ButtonVxod_Click(object sender, RoutedEventArgs e)
        {
            Users userData = new Users();
            userData = TravelHubEntities.GetContext().Users.Where(u => u.Login == Logine.Text && u.Password == Parole.Password).FirstOrDefault();

            if (tries >= 3)
            {
                DateTime date = DateTime.Now;
                MessageBox.Show($"Вы ввели неправильные данные больше трёх раз. система заблокирована на {10} секунд");
                while (date.AddSeconds(10) > DateTime.Now)
                {
                    LoginBox.IsEnabled = false;
                    Parole.IsEnabled = false;
                    ButtonVxod.IsEnabled = false;
                }
                LoginBox.IsEnabled = true;
                Parole.IsEnabled = true;
                ButtonVxod.IsEnabled = true;
            }
            if (userData == null)
            {
                MessageBox.Show("Данные введены неверно или пользователя не сущесвует");
                tries++;
                return;
            }
            UserInfo.Login = userData.Login;
            UserInfo.Name = userData.Name;
            UserInfo.Surname = userData.Surname;
            UserInfo.SecondName = userData.SecondName;

            if (userData.Login == "grom")
            {
                NavigationService.Navigate(new AdminRoomsPage());
                MessageBox.Show($"Добро пожаловать, {userData.Name}!");
            }
            else
            {
                NavigationService.Navigate(new HotelPage());
                MessageBox.Show($"Добро пожаловать, {userData.Name}!");
            }

        }
    }
}