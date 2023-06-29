using JPTS13Bank.Models;

namespace JPTS13Bank.Repositories.Interfaces
{
    public interface IAccountRepository
    {
        void RegisterAccount(Account model);
        Account GetAccountById(int id);
        List<Account> GetAllAcounts();
    }
}
