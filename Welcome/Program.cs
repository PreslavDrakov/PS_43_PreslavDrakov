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
            User user = new User("Preslav", "1234", "preslav@gmail.com", 0884525566, UserRolesEnum.STUDENT, FacultyEnum.FCST, 43, 3, 121221158);
            UserViewModel userModel = new UserViewModel(user);
            UserView userView = new UserView(userModel);
            userView.DisplayFullInfo();
            Console.WriteLine(user.Password);
            Console.WriteLine(BC.EnhancedVerify("1234", user.Password));
            Console.ReadKey();
        }
    }
}
