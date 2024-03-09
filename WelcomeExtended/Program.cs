using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
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

        }
    }
}
