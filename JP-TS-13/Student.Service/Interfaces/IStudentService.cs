using Student.Models;

namespace Student.Service
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();

        //TODO - სტუდენტების ცხრილის მსგავსად შექმენით მასწავლებლების ცხრილი ზუსტად შემდეგი პარამეტრებით
        //FirstName
        //LastName
        //DateOfBirth
        //Pin
        //Salary
    }
}
