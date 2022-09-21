using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Entrance_and_registration.Core
{
    internal static class UserValidator
    {
        public static bool Validate (string login, string password)
        {
            if (login == "Dream" && password == "Team")
            {
                MessageBox.Show("Вы успешно вошли");
                return true;
            }
            else
            {
                MessageBox.Show("Неправельный пароль или логин!");
                return false;
            }
        }
    }
}
