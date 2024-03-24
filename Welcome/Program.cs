using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User 
            { 
                Id =1,
                Name = "Preslav",
                Password = "password",
                Email = "pdrakov@tu-sofia.bg",
                Phone = "0889988990",
                Role = UserRolesEnum.STUDENT,
                Faculty = FacultyEnum.FCST,
                Group = 43,
                Course = 3,
                FacultyNumber = "121221158",
                Expires = DateTime.Now.AddYears(5)
            };
            UserViewModel userModel = new UserViewModel(user);
            UserView userView = new UserView(userModel);
            userView.DisplayFullInfo();
            //Console.WriteLine(user.ValidatePassword("aabcd"));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
