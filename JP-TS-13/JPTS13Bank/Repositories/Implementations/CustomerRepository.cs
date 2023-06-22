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
        /// მომხმარებლის ძებნა გადაცემული ID -ის მიხედვით
        /// </summary>
        /// <param name="id">გადაცემული ID</param>
        /// <returns>Customer</returns>
        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// მომხმარებლის ჩაწერა ფაილში
        /// </summary>
        /// <param name="model">ახალი მომხმარებელი</param>
        public void RegisterCustomer(Customer model)
        {
            throw new NotImplementedException();
        }
    }
}
