using JPTS13Bank.Models;
using JPTS13Bank.Repositories;

CustomerRepository repo = new();



Customer newCustomer2 = new Customer
{
    Name = "Giorgi",
    Email = "Giorgi@gmail.com",
    IdentityNumber = "12345678945",
    PhoneNumber = "555337681",
    Type = CustomerType.Phyiscial
};



repo.RegisterCustomer(newCustomer2);


Console.ReadLine();