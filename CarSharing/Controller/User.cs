using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CarSharing.Controller
{
    class User : Model
    {

        public static CarSharing.Model.User AuthorizedUser{ get; private set; }

        public bool AuthUser(string login, string password)
        {
            var user = carShaeringEntities.Users.Where(i => login == i.Email && password == i.Password);

            if (user.Count() > 0)
            {
                AuthorizedUser = user.FirstOrDefault();
                return true;
            }

            SharedClass.MessageBoxWarning("Неправильный логин или пароль"); 

            return false;

        }

        public bool CheckFields(string login, string password)
        {
            if (String.IsNullOrWhiteSpace(login) || password == "")
            {
                SharedClass.MessageBoxWarning("Все поля должны быть заполнены");
                return false; 
            }

            return true; 
        }


    }
}
