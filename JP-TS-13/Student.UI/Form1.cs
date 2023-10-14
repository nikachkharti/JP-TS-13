using Student.Service;
using Student.Service.Interfaces;

namespace Student.UI
{
    public partial class Form1 : Form
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;

        public Form1()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _teacherService = new TeacherService();
        }

        private void showStudentsBtn_Click(object sender, EventArgs e)
        {
            var allStudents = _studentService.GetAllStudents();
        }

        private void showTeachersBtn_Click(object sender, EventArgs e)
        {
            var allTeachers = _teacherService.GetAllTeachers();
        }

        private void getSingleStudentBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(studentidValue.Text, out int studentId);
        }
    }
}