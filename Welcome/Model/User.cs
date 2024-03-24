using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private const int _ShiftKey = 6;
        private string _password = string.Empty;
        private int _id;
        private string _name;
        private DateTime _expires;
        private FacultyEnum _facultyEnum;
        private string _email = string.Empty;
        private string _facultyNumber=string.Empty;
        private string _phone = string.Empty;
        private UserRolesEnum _rolesEnum;
        private int _group;
        private int _course;

        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Password
        {
            get
            {
                return DecryptPassword(_password, _ShiftKey);
            }
            set
            {
                _password = EncryptPassword(value, _ShiftKey);
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        public UserRolesEnum Role
        {
            get
            {
                return _rolesEnum;
            }
            set
            {
                _rolesEnum = value;
            }
        }
        public FacultyEnum Faculty
        {
            get
            {
                return _facultyEnum;
            }
            set
            {
                _facultyEnum = value;
            }
        }
        public int Group
        {
            get
            {
                return _group;
            }
            set
            {
                _group = value;
            }
        }
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
            }

        }
        public string FacultyNumber
        {
            get
            {
                return _facultyNumber;
            }
            set
            {
                _facultyNumber = value;
            }
        }
        public DateTime Expires
        {
            get
            {
                return _expires;
            }
            set
            {
                _expires = value;
            }
        }
        /*
        public User(int id, string name, string password, string email, int phone, UserRolesEnum role, FacultyEnum fac, int gr, int cource, int facNum, DateTime expires)
        {
            Id = id;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Role = role;
            Faculty = fac;
            Group = gr;
            Course = cource;
            FacultyNumber = facNum;
            Expires = expires;
        }*/

        private static string EncryptPassword(string input, int shiftKey)
        {
            string encryptedText = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    char shiftedChar = (char)(((ch - 'a' + shiftKey) % 26) + 'a');
                    encryptedText += shiftedChar;
                }
                else
                {
                    encryptedText += ch;
                }
            }

            return encryptedText;
        }

        private static string DecryptPassword(string input, int shiftKey)
        {
            string decryptedText = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    char shiftedChar = (char)(((ch - 'a' - shiftKey + 26) % 26) + 'a');
                    decryptedText += shiftedChar;
                }
                else
                {
                    decryptedText += ch;
                }
            }

            return decryptedText;
        }
        public bool ValidatePassword(string password)
        {
            if (password.Equals(DecryptPassword(_password, _ShiftKey)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Role: {Role}, Faculty Number: {FacultyNumber}, Email: {Email}";
        }
    }
}
