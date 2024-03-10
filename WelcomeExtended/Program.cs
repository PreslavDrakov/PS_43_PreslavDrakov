using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new User("Preslav", "1234", "preslav@gmail.com", 0884525566, UserRolesEnum.STUDENT, FacultyEnum.FCST, 43, 3, 121221158);
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.DisplayFullInfo();
                view.DisplayError();
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Delegates.Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
            UserData userData = new UserData();
            User studentUser = new User("Preslav", "1234", "preslav@gmail.com", 0884525566, UserRolesEnum.STUDENT, FacultyEnum.FCST, 43, 3, 121221158);
            User studentUser2 = new User("Angel", "1234", "student@gmail.com", 0787958, UserRolesEnum.STUDENT, FacultyEnum.FCST, 43, 3, 121221038);
            User teacherUser = new User("Ivo", "1234", "teacher@gmail.com", 036985214, UserRolesEnum.PROFESSOR, FacultyEnum.FCST, 43, 3, 121221158);
            User adminUser = new User("Admin", "1234", "admin@gmail.com", 085858585, UserRolesEnum.ADMIN, FacultyEnum.FCST, 43, 3, 121221158);
            userData.AddUser(studentUser);
            userData.AddUser(studentUser2);
            userData.AddUser(teacherUser);
            userData.AddUser(adminUser);
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            // Проверка дали потребителят съществува и извеждане на информацията за него
            if (userData.ValidateUserLambda(name, password))
            {
                User user = userData.GetUser(name, password);
                UserViewModel userModel = new UserViewModel(user);
                UserView userView = new UserView(userModel);
                userView.DisplayFullInfo();
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }
}
