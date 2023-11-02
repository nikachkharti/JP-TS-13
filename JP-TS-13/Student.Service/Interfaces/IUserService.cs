using Student.Models;

namespace Student.Service.Interfaces
{
    public interface IUserService
    {
        List<UserModel> GetAllUsers();
        void AddUser(UserModel user);
    }
}
