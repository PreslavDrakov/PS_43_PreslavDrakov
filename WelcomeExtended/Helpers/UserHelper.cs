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
        public static bool ValidateCredentials(UserData user, string name, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("The name cannot be empty.", nameof(name));
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("The password cannot be empty.", nameof(password));
                }

                return user.ValidateUser(name, password);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Validation error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }


        public static User GetUser(this User user, string name, string password)
        {
            return user.GetUser(name, password);
        }
    }
}
