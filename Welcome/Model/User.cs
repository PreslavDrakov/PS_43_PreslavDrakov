using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _password;
        public string Name { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                this._password = BC.EnhancedHashPassword(value, 13);
            }
        }
        public string Email { get; set; }
        public int Phone { get; set; }
        public UserRolesEnum Role { get; set; }
        public FacultyEnum Faculty { get; set; }
        public int Group { get; set; }
        public int Course { get; set; }
        public int FacultyNumber { get; set; }
        public User(string name, string password, string email, int phone, UserRolesEnum role, FacultyEnum fac, int gr, int cource, int facNum)
        {
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Role = role;
            Faculty = fac;
            Group = gr;
            Course = cource;
            FacultyNumber = facNum;
        }
    }
}
