using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;
        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public void DisplayPersonalInfo()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine($"User: {_viewModel.Name}");
            Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine($"Phone: {_viewModel.Phone}");
        }
        public void DisplayFullInfo()
        {
            Console.WriteLine($"User: {_viewModel.Name}");
            Console.WriteLine($"Email: {_viewModel.Email}");
            Console.WriteLine($"Phone: {_viewModel.Phone}");
            Console.WriteLine($"Role: {_viewModel.Role}");
            Console.WriteLine($"Faculty: {_viewModel.Faculty}");
            Console.WriteLine($"Group: {_viewModel.Group}");
            Console.WriteLine($"Course: {_viewModel.Course}");
            Console.WriteLine($"Faculty number: {_viewModel.FacultyNumber}");
        }
        public void DisplayUniversityInfo()
        {
            Console.WriteLine("Welcome to TU - Sofia");
            Console.WriteLine($"User: {_viewModel.Name}");
            Console.WriteLine($"Role: {_viewModel.Role}");
            Console.WriteLine($"Faculty: {_viewModel.Faculty}");
            Console.WriteLine($"Group: {_viewModel.Group}");
            Console.WriteLine($"Course: {_viewModel.Course}");
            Console.WriteLine($"Faculty number: {_viewModel.FacultyNumber}");
        }
    }
}
