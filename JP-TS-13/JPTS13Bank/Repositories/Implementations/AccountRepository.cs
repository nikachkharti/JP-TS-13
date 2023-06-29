using JPTS13Bank.Models;
using JPTS13Bank.Repositories.Interfaces;

namespace JPTS13Bank.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private const string _filePath = @"../../../Data/Accounts.csv";
        List<Account> _accounts = new();

        public AccountRepository()
        {
            _accounts = File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToAccount())
                .ToList();
        }

        public Account GetAccountById(int id)
        {
            return _accounts.FirstOrDefault(x => x.Id == id);
        }

        public List<Account> GetAllAcounts()
        {
            _accounts = File
                .ReadAllLines(_filePath)
                .Skip(1)
                .Select(x => x.ToAccount())
                .ToList();

            return _accounts;
        }

        public void RegisterAccount(Account model)
        {
            int maxId = _accounts.Max(x => x.Id);
            model.Id = maxId += 1;
            _accounts.Add(model);
            File.AppendAllText(_filePath, model.ToCsv());
        }
    }
}
