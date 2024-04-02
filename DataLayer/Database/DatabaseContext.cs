using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFoled = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFoled, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(equals => equals.Id).ValueGeneratedOnAdd();
            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "Horhe",
                Password = "1234",
                Email = "admin@email.com",
                Phone = "123123",
                Faculty = FacultyEnum.FCST,
                Role = UserRolesEnum.ADMIN,
                Group = 43,
                Course = 4,
                FacultyNumber = "123123",
                Expires = DateTime.Now.AddYears(10)
            };
            modelBuilder.Entity<DatabaseUser>().HasData(user);
            var user2 = new DatabaseUser()
            {
                Id = 2,
                Name = "Gosho",
                Password = "1234",
                Email = "admin@email.com",
                Phone = "123123",
                Faculty = FacultyEnum.FCST,
                Role = UserRolesEnum.STUDENT,
                Group = 43,
                Course = 4,
                FacultyNumber = "123123",
                Expires = DateTime.Now.AddYears(10)
            };
            modelBuilder.Entity<DatabaseUser>().HasData(user2);
            var user3 = new DatabaseUser()
            {
                Id = 3,
                Name = "Pesho",
                Password = "1234",
                Email = "admin@email.com",
                Phone = "123123",
                Faculty = FacultyEnum.FCST,
                Role = UserRolesEnum.STUDENT,
                Group = 43,
                Course = 4,
                FacultyNumber = "123123",
                Expires = DateTime.Now.AddYears(10)
            };
            modelBuilder.Entity<DatabaseUser>().HasData(user3);
        }
        public DbSet<DatabaseUser> Users { get; set; }
        
    }
}
