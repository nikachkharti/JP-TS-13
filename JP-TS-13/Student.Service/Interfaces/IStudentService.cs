using Student.Models;

namespace Student.Service.Interfaces
{
    public interface IStudentService
    {
        List<StudentModel> GetAll();
    }
}
