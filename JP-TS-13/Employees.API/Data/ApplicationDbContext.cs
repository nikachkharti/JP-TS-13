using Employees.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Employees.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        FirstName = "Irakli",
                        LastName = "Rogava",
                        CompanyId = 1
                    },
                    new Employee
                    {
                        Id = 2,
                        FirstName = "Giorgi",
                        LastName = "Omanadze",
                        CompanyId = 1
                    },
                    new Employee
                    {
                        Id = 3,
                        FirstName = "Giorgi",
                        LastName = "Jibladze",
                        CompanyId = 2

                    },
                    new Employee
                    {
                        Id = 4,
                        FirstName = "Lizi",
                        LastName = "Nemsiwverdize",
                        CompanyId = 3
                    }
                );


            modelBuilder.Entity<Company>().HasData(
                    new Company
                    {
                        Id = 1,
                        Name = "Microsoft",
                        CreateDate = DateTime.Now,
                        Description = "Microsoft company"
                    },
                    new Company
                    {
                        Id = 2,
                        Name = "Apple",
                        CreateDate = DateTime.Now,
                        Description = "Apple company"
                    },
                    new Company
                    {
                        Id = 3,
                        Name = "Intel",
                        CreateDate = DateTime.Now,
                        Description = "Intel company"
                    }
                );

            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Email = "admin@gmail.com",
                        Password = "admin",
                        Role = "administrator"
                    },
                    new User
                    {
                        Id = 2,
                        Email = "customer@gmail.com",
                        Password = "customer",
                        Role = "customer"
                    }
                );
        }

    }
}
