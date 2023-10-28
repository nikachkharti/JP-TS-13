using Student.Models;

namespace Student.Service
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudent(int id);
        void AddStudent(StudentModel newStudentObject);
        void DeleteStudent(int id);
        void UpdateStudent(StudentModel newStudentObject);
    }
}
