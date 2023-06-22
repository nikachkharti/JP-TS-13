using JPTS13Bank.Models;
using JPTS13Bank.Repositories;

CustomerRepository repo = new();
repo.RegisterCustomer(new Customer
{
    Name = "Nika",
    Email = "nika@gmail.com",
    IdentityNumber = "123456789456",
    PhoneNumber = "555887744",
    Type = CustomerType.Phyiscial
});


Console.ReadLine();