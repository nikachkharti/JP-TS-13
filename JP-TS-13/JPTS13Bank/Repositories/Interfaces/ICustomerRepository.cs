using JPTS13Bank.Models;

namespace JPTS13Bank.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        void RegisterCustomer(Customer model);

        //TODO 1. დაწერეთ მომხმარებლის წაშლის ლოგიკა, ფუნქციამ უნდა მიიღოს წასაშლელი მომხმარებლის id
        // და გააქროს ის ფაილიდან
    }
}
