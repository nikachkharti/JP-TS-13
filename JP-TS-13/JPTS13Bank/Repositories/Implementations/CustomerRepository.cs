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
            //TODO
            //1.სანამ ფაილში ჩაწერთ მონაცემებს შეამოწმეთ რომ
            //სახელი იყოს სავალდებულო
            //პირადი ნომერი უნდა იყოს 11 ნიშნა
            //ტელეფონის ნომერი უნდა იყოს 9 ნიშნა
            //ელ-ფოსტა უნდა შეიცავდეს @ და . სიმბოლოებს

            int maxId = _customers.Max(x => x.Id);
            model.Id = maxId += 1;
            _customers.Add(model);
            File.AppendAllText(_filePath, model.ToCsv());
        }
    }
}
