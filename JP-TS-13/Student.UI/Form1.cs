using Student.Models;
using Student.Service;
using Student.Service.Interfaces;

namespace Student.UI
{
    public partial class Form1 : Form
    {
        private readonly IStudentService _studentService;
        private readonly ITeacherService _teacherService;
        public StudentModel? SelectedStudent { get; set; }

        public Form1()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _teacherService = new TeacherService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            _studentService.AddStudent(new Models.StudentModel
            {
                FirstName = firstNameValue.Text,
                LastName = lastNameValue.Text,
                DateOfBirth = dobValue.Value,
                Pin = pinValue.Text
            });

            RefreshData();
            ClearForm();
            MessageBox.Show("ახალი სტუდენტი წარმატებით დაემატა", "ინფორამცია დაემატა", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStudent = StudentsList.SelectedItem as StudentModel;

            if (SelectedStudent != null)
            {
                firstNameValue.Text = SelectedStudent.FirstName;
                lastNameValue.Text = SelectedStudent.LastName;
                dobValue.Value = SelectedStudent.DateOfBirth;
                pinValue.Text = SelectedStudent.Pin;
            }
        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            firstNameValue.Text = string.Empty;
            lastNameValue.Text = string.Empty;
            dobValue.Value = DateTime.Now;
            pinValue.Text = string.Empty;
        }

        private void RefreshData()
        {
            StudentsList.DataSource = _studentService.GetAllStudents();
        }

    }
}