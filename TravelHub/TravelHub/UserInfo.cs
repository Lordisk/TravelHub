using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub
{
    public class UserInfo
    {
       

        public static string Name { get; set; }

        public static string SecondName { get; set; }

        public static string Surname { get; set; }

        public static string Role { get; set; }

        public static string Email { get; set; }

        public static string Login { get; set; }

        public static string Password { get; set; }

        public UserInfo() { }
        public UserInfo(string Name, string SecondName, string Surname, string Email, string Login, string Password)
        {
            string name = Name;
            string secondName = SecondName;
            string surname = Surname;
            string email = Email;
            string login = Login;
            string password = Password;
        }
    }
}

