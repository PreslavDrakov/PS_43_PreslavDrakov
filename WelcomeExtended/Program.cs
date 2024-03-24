using Welcome.Model;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using WelcomeExtended.Others;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            HashLogger logger = new HashLogger("Example 1");
            logger.Log(LogLevel.Information, new EventId(1), "Logging information", null, (state, ex) => state.ToString());
            logger.Log(LogLevel.Error, new EventId(2), "Logging error", null, (state, ex) => state.ToString());


            var recordedMessages = logger.GetAllLogMessages();
            foreach (var message in recordedMessages)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine();
            HashLogger logger1 = new HashLogger("Example 2");
            logger1.Log(LogLevel.Warning, new EventId(1), "Logging Warning", null, (state, ex) => state.ToString());
            logger1.Log(LogLevel.Error, new EventId(2), "Logging error", null, (state, ex) => state.ToString());

            
            logger1.PrintEventById(1);


            
            logger1.PrintEventById(2);


            HashLogger logger2 = new HashLogger("Example");
            logger2.Log(LogLevel.Critical, new EventId(1), "Logging critical", null, (state, ex) => state.ToString());
            logger2.Log(LogLevel.Error, new EventId(2), "Logging error", null, (state, ex) => state.ToString());


            bool deleted = logger2.DeleteEventById(1);
            if (deleted)
            {
                Console.WriteLine("Event with ID 1 deleted successfully.");
                var recordedMessagesAfterDeletion = logger2.GetAllLogMessages();
                foreach (var message in recordedMessages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("Event with ID 1 not found.");
            }


            deleted = logger2.DeleteEventById(3);
            if (deleted)
            {
                Console.WriteLine("Event with ID 3 deleted successfully.");
            }
            else
            {
                Console.WriteLine("Event with ID 3 not found.");
            }

            try
            {
                var user = new User
                {
                    Name = "John Smith",
                    Password = "password",
                    Role = Welcome.Others.UserRolesEnum.STUDENT
                };
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.DisplayPersonalInfo();
                view.DisplayError();
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Delegates.Log3);
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }*/

            try
            {
                UserData userData = new UserData();

                userData.AddUser(new User
                {
                    Name = "student",
                    Password = "1234",
                    Role = Welcome.Others.UserRolesEnum.STUDENT
                });

                userData.AddUser(new User
                {
                    Name = "student2",
                    Password = "1234",
                    Role = Welcome.Others.UserRolesEnum.STUDENT
                });

                userData.AddUser(new User
                {
                    Name = "teacher",
                    Password = "1234",
                    Role = Welcome.Others.UserRolesEnum.PROFESSOR
                });

                userData.AddUser(new User
                {
                    Name = "admin",
                    Password = "1234",
                    Role = Welcome.Others.UserRolesEnum.ADMIN
                });


                Console.Write("Enter username:");
                string username = Console.ReadLine();
                Console.Write("Enter password:");
                string password = Console.ReadLine();


                if (userData.ValidateCredentials(username, password))
                {

                    User user = userData.GetUser(username, password);

                    if (user != null)
                    {

                        string logMessage = $"Successful login: {user.ToString()}";


                        var log = new ActionOnError(Delegates.Log4);
                        log(logMessage);

                        Console.WriteLine(user.ToString());
                    }
                    else
                    {

                        string logMessage = $"Unsuccessful login: {username}, {password}";


                        var log = new ActionOnError(Delegates.Log5);
                        log(logMessage);

                        Console.WriteLine("Error: User details not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                var log = new ActionOnError(Delegates.Log4);
                log(ex.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }

        }
    }
}
