using Student.Models;
using Student.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.UI
{
    public partial class StudentPersonalCabinetForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly UserModel _loggedInStudent;
        private StudentModel SelectedStudent { get; set; }

        public StudentPersonalCabinetForm(UserModel UserModelFromDatabase)
        {
            InitializeComponent();
            _studentService = new StudentService();
            _loggedInStudent = UserModelFromDatabase;
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
                        Id = _loggedInStudent.Id
                    });

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

        private StudentModel GetStudentInfo() => _studentService.GetStudent(_loggedInStudent.Id);

        private void FillTheForm()
        {
            var studentFromDatabase = GetStudentInfo();

            if (studentFromDatabase != null)
            {
                firstNameValue.Text = studentFromDatabase.FirstName;
                lastNameValue.Text = studentFromDatabase.LastName;
                dobValue.Value = studentFromDatabase.DateOfBirth;
                pinValue.Text = studentFromDatabase.Pin;
            }
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

        private void StudentPersonalCabinetForm_Load(object sender, EventArgs e)
        {
            FillTheForm();
        }
    }
}
