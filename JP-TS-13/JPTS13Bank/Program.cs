using JPTS13Bank.Models;
using JPTS13Bank.Repositories;

CustomerRepository repo = new();
var a = repo.GetCustomerById(1);

Console.ReadLine();