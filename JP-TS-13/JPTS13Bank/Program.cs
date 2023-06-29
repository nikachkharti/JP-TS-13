using JPTS13Bank.Models;
using JPTS13Bank.Repositories;
using JPTS13Bank.Repositories.Implementations;

CustomerRepository customerRepo = new();
AccountRepository accountRepo = new();


//Customer newCustomer2 = new Customer
//{
//    Name = "Giorgi",
//    Email = "Giorgi@gmail.com",
//    IdentityNumber = "12345678945",
//    PhoneNumber = "555337681",
//    Type = CustomerType.Phyiscial
//};

//customerRepo.RegisterCustomer(newCustomer2);


Account accountForCustomer2 = new Account()
{
    Iban = "GE12345678945612345874",
    Currency = "GEL",
    Balance = 100,
    CustomerId = 21
};

accountRepo.RegisterAccount(accountForCustomer2);




Console.ReadLine();