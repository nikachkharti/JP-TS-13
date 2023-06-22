using JPTS13Bank.Models;

namespace JPTS13Bank.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        void RegisterCustomer(Customer model);
    }
}
