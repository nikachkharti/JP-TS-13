using Student.Models;
//Dependency injection

namespace Student.Service.Interfaces
{
    public interface ITeacherService
    {
        List<TeacherModel> GetAllTeachers();
    }
}
