using JPTS13Bank.Repositories;
using System.Diagnostics.CodeAnalysis;

namespace JPTS13Bank.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Customer Customer { get; set; }

        public override bool Equals(object obj)
        {
            return new AccountEquilityComparer().Equals(this, obj as Account);
        }

        public override int GetHashCode()
        {
            return new AccountEquilityComparer().GetHashCode(this);
        }
    }


    class AccountEquilityComparer : IEqualityComparer<Account>
    {
        public bool Equals(Account x, Account y) => x.Iban == y.Iban;
        public int GetHashCode(Account obj) => obj.Iban.Length;
    }


    internal static class AccountExtension
    {
        internal static string ToCsv(this Account input) =>
           $"\n{input.Id},{input.Iban},{input.Currency},{input.Balance},{input.CustomerId},{input.Name}";

        internal static Account ToAccount(this string input)
        {
            string[] csvInput = input.Split(',');

            Account result = new();
            result.Id = int.Parse(csvInput[0]);
            result.Iban = csvInput[1];
            result.Currency = csvInput[2];
            result.Balance = decimal.Parse(csvInput[3]);
            result.CustomerId = int.Parse(csvInput[4]);
            result.Name = csvInput[5];
            result.Customer = FindCustomer(result.CustomerId);

            return result;
        }

        private static Customer FindCustomer(int id)
        {
            CustomerRepository customerRepository = new();
            var allCustomers = customerRepository.GetAllCustomers();

            return allCustomers.FirstOrDefault(x => x.Id == id);
        }
    }

}
