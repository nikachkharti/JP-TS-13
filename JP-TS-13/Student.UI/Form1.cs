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
            StudentsList.DataSource = allStudents;
        }

        private void showTeachersBtn_Click(object sender, EventArgs e)
        {
            var allTeachers = _teacherService.GetAllTeachers();
        }

        private void getSingleTeacherBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(teacherIdValue.Text, out int teacherId);

            try
            {
                var teacher = _teacherService.GetSingleTeacher(teacherId);

                if (teacher != null)
                {
                    foundTeacherName.Text = $"{teacher.FirstName} {teacher.LastName}";
                    foundTeacherName.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}