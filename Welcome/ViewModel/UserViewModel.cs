using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;
        public UserViewModel(User user)
        {
            _user = user;
        }
        public int Id
        {
            get { return _user.Id; }
            set { _user.Id = value; }
        }
        public string Name
        {
            get { return _user.Name; }
            set { _user.Name = value; }
        }
        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }
        public string Email
        {
            get { return _user.Email; }
            set { _user.Email = value; }
        }
        public string Phone
        {
            get { return _user.Phone; }
            set { _user.Phone = value; }
        }
        public UserRolesEnum Role
        {
            get { return _user.Role; }
            set { _user.Role = value; }
        }
        public FacultyEnum Faculty
        {
            get { return _user.Faculty; }
            set { _user.Faculty = value; }
        }
        public int Group
        {
            get { return _user.Group; }
            set { _user.Group = value; }
        }
        public int Course
        {
            get { return _user.Course; }
            set { _user.Course = value; }
        }
        public string FacultyNumber
        {
            get { return _user.FacultyNumber; }
            set { _user.FacultyNumber = value; }
        }
        public DateTime Expires
        {

            get { return _user.Expires; }
            set { _user.Expires = value; }

        }
    }
}
