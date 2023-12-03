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
using System.Windows.Shapes;


namespace TravelHub
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        TravelHubEntities db;
        public RegistrationWindow()
        {
            InitializeComponent();
            db = new TravelHubEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users authUser = new Users();
            using (TravelHubEntities db = new TravelHubEntities()) 
            {
                authUser = db.Users.Where(b => b.Login == LoginBox && b.Password == Parol).FirstOrDefault();
            }
            if (authUser != null)
            {
                MessageBox.Show("Успешная авторизация");
                UserWindow window = new UserWindow();
                window.Show();
                this.Close();
            }
            else
                MessageBox.Show("Неккоректный вход");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Surname = SurnameBox.Text.Trim();
            string Name = NameBox.Text.Trim();
            string SecondName = SecondN.Text.Trim();
            string Email = EmailBox.Text.Trim();
            string Login = LoginBox.Text.Trim();
            string Password = Parol.Password.Trim();
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                EmailBox.ToolTip = "Это поле введено некорректно";
                EmailBox.Background = Brushes.DarkRed;
            }
            else
            {
                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;
            }
            if (Password.Length < 6)
            {
                Parol.ToolTip = "Это поле введено некорректно";
                Parol.Background = Brushes.DarkRed;
            }
            else
            {
                Parol.ToolTip = "";
                Parol.Background = Brushes.Transparent;
            }
            MessageBox.Show("Успешная регистрация!");
            DataTransfer user = new DataTransfer(Name, SecondName, Surname, Email, Login, Password);
            db.Users.Add(user);
            db.SaveChanges();

            UserWindow window = new UserWindow();
            window.Show();
            this.Close();
        }
    }
}
