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
        public UserModel LoggedInUser { get; set; }

        public Form1(UserModel loggedInUser)
        {
            InitializeComponent();
            _studentService = new StudentService();
            _teacherService = new TeacherService();
            LoggedInUser = loggedInUser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = LoggedInUser.Email;
            StudentsList.SelectionMode = SelectionMode.MultiExtended;
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
            try
            {
                if (FormIsValid())
                {
                    if (StudentIsUnique())
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
                    else
                    {
                        MessageBox.Show("ბაზაში მსგავსი სტუდენტი უკვე არსებობს", "უნიკალურობის შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("შემოყვანილი ინფორამაცია არასწორია", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool FormIsValid()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(firstNameValue.Text) || firstNameValue.Text.Length > 50)
            {
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(lastNameValue.Text) || lastNameValue.Text.Length > 50)
            {
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(pinValue.Text)
                || pinValue.Text.Length != 11
                || pinValue.Text.Any(x => char.IsLetter(x)))
            {
                result = false;
            }

            return result;
        }


        private bool StudentIsUnique()
        {
            return !_studentService.GetAllStudents()
                .Any(x => x.Pin.Contains(pinValue.Text.Trim()));
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult deleteDialog = MessageBox.Show("ნამდვილად გსურთ მონაცემის წაშლა?", "მონაცემის წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteDialog == DialogResult.Yes)
                {
                    _studentService.DeleteStudent(SelectedStudent.Id);
                    RefreshData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormIsValid())
                {
                    _studentService.UpdateStudent(new StudentModel
                    {
                        FirstName = firstNameValue.Text,
                        LastName = lastNameValue.Text,
                        DateOfBirth = dobValue.Value,
                        Pin = pinValue.Text,
                        Id = SelectedStudent.Id
                    });

                    RefreshData();
                    ClearForm();
                    MessageBox.Show("ახალი სტუდენტი წარმატებით დაემატა", "ინფორამცია დაემატა", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("შემოყვანილი ინფორამაცია არასწორია", "არასწორი ინფორმაცია", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}