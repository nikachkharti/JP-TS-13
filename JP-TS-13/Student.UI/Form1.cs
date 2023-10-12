using Student.Service;

namespace Student.UI
{
    public partial class Form1 : Form
    {
        private readonly IStudentService _studentService;
        public Form1()
        {
            InitializeComponent();
            _studentService = new StudentService();
        }

        private void showStudentsBtn_Click(object sender, EventArgs e)
        {
            var allStudents = _studentService.GetAllStudents();
        }
    }
}