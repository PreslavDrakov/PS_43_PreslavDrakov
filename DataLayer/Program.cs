using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;
using Welcome;

using (var context = new DatabaseContext())
{
    context.Database.EnsureCreated();
    context.Add<DatabaseUser>(new DatabaseUser()
    {
        Name = "user",
        Password = "password",
        Email = "user@tu-sofia.bg",
        FacultyNumber = "123123",
        Expires = DateTime.Now,
        Role = UserRolesEnum.STUDENT
    });
    context.SaveChanges();
    var users = context.Users.ToList();

    while (true) //To always have the options available for choosing, but can quit with 
                 //option 4
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. View all users");
        Console.WriteLine("2. Add a new user");
        Console.WriteLine("3. Delete a user");
        Console.WriteLine("4. Exit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ViewAllUsers();
                break;
            case "2":
                AddNewUser();
                break;
            case "3":
                DeleteUser();
                break;
            case "4":
                Console.WriteLine("Exiting...");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
    Console.ReadKey();

}
 static void ViewAllUsers()
{
    using (var context = new DatabaseContext())
    {
        var users = context.Users.ToList();
        Console.WriteLine("All users:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}");
        }
    }
}
 static void AddNewUser()
{
    Console.Write("Enter name: ");
    string name = Console.ReadLine();

    Console.Write("Enter password: ");
    string password = Console.ReadLine();

    using (var context = new DatabaseContext())
    {
        context.Add<DatabaseUser>(new DatabaseUser()
        {
            Name = name,
            Password = password,
            Expires = DateTime.Now.AddYears(1),
            Role = UserRolesEnum.STUDENT
        });
        context.SaveChanges();
        Console.WriteLine("User added successfully.");
    }
}
 static void DeleteUser()
{
    Console.Write("Enter the name of the user you want to delete: ");
    string name = Console.ReadLine();

    using (var context = new DatabaseContext())
    {
        var userToDelete = context.Users.FirstOrDefault(u => u.Name == name);
        if (userToDelete != null)
        {
            context.Users.Remove(userToDelete);
            context.SaveChanges();
            Console.WriteLine($"User '{name}' deleted successfully.");
        }
        else
        {
            Console.WriteLine($"User '{name}' not found.");
        }
    }
}