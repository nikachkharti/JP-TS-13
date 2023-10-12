using Student.Models;

namespace Student.Service
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();
    }
}
