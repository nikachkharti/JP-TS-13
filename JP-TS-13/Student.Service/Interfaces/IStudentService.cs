using Student.Models;

namespace Student.Service
{
    public interface IStudentService
    {
        List<StudentModel> GetAllStudents();

        //TODO - სტუდენტების ცხრილის მსგავსად შექმენით მასწავლებლების ცხრილი ზუსტად შემდეგი პარამეტრებით
        //Id PRIMART KEY   
        //FirstName
        //LastName
        //DateOfBirth
        //Pin
        //Salary
    }
}
