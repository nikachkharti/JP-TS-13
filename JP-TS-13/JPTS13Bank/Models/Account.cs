using JPTS13Bank.Repositories;

namespace JPTS13Bank.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

    internal static class AccountExtension
    {
        internal static string ToCsv(this Account input) =>
           $"\n{input.Id},{input.Iban},{input.Currency},{input.Balance},{input.CustomerId}";

        internal static Account ToAccount(this string input)
        {
            string[] csvInput = input.Split(',');

            Account result = new();
            result.Id = int.Parse(csvInput[0]);
            result.Iban = csvInput[1];
            result.Currency = csvInput[2];
            result.Balance = decimal.Parse(csvInput[3]);
            result.CustomerId = int.Parse(csvInput[4]);
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
