using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {

        public static string ToString(this User user)
        {
            return $"User: {user.Name}, Role: {user.Role}\n";
        }
        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
                return false;

            return userData.ValidateUserLinq(name, password);
        }

        public static User GetUser(this UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }
}
