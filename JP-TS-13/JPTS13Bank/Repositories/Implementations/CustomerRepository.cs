using JPTS13Bank.Models;
using JPTS13Bank.Repositories.Interfaces;

namespace JPTS13Bank.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private const string _filePath = @"../../../Data/Customers.csv";
        private List<Customer> _customers = new();
        public CustomerRepository()
        {
            _customers = File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToCustomer())
                .ToList();
        }

        /// <summary>
        /// დაწერეთ ფუნქცია რომელიც _customers ლისტში მოძებნის და დააბრუნებს
        /// იმ კონკრეტულ customer-ს რომლის ID ემთხვევა გადაცემულ ID -ს.
        /// </summary>
        /// <param name="id">გადაცემული ID</param>
        /// <returns>Customer</returns>
        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void RegisterCustomer(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
