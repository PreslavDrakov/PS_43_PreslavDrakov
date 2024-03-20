using Welcome.Model;
using Welcome.Others;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> _users;
        private int _nextId;
        public UserData()
        {
            _users = new List<User>();
            _nextId = 0;
        }
        public void AddUser(User user)
        {
            user.Id = _nextId++;
            _users.Add(user);
        }
        public void DeleteUser(User user)
        {
            _users.Remove(user);
        }
        public bool ValidateUser(string name, string password)
        {
            foreach (var user in _users)
            {
                if (user.Name == name && user.ValidatePassword(password))
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidateUserLambda(string name, string password)
        {
            return _users.Where(x => x.Name == name && x.ValidatePassword(password)).FirstOrDefault() != null ? true : false;
        }
        public bool ValidateUserLinq(string name, string password)
        {
            var ret = from user in _users
                      where user.Name == name && user.ValidatePassword(password)
                      select user.Id;
            return ret != null ? true : false;
        }
        public User GetUser(string name, string password)
        {
            try
            {
                return _users.FirstOrDefault(u => ValidateUserLambda(name, password));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public void SetActive(string name, DateTime expirationDate)
        {
            var user = _users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                user.Expires = expirationDate;
            }
        }
        public void AssignUserRole(string name, UserRolesEnum role)
        {
            var user = _users.FirstOrDefault(u => u.Name == name);
            if (user != null)
            {
                user.Role = role;
            }
        }


    }
}
