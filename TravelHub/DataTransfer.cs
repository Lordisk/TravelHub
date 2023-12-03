using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelHub
{
     class DataTransfer
    {
        public  int idUser { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public DataTransfer() { }
        public DataTransfer(string Name, string SecondName, string Surname, string Email, string Login, string Password) 
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.Surname = Surname;
            this.Email = Email;
            this.Login = Login;
            this.Password = Password;
        }
    }
}
