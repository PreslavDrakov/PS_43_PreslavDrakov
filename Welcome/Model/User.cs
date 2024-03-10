using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private const int ShiftKey = 6; 
        private string _password = string.Empty;

        public int Id { get; set; }
        public string Name { get; set; }

        public string Password
        {
            get
            {
                return DecryptPassword(_password, ShiftKey);
            }
            set
            {
                _password = EncryptPassword(value, ShiftKey);
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
            if (password.Equals(DecryptPassword(_password, ShiftKey)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }   
    }
}
