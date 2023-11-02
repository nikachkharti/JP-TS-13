using Student.Models;
using Student.Service;
using Student.Service.Interfaces;

namespace Student.UI
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public UserModel UserThatSignsIn { get; set; } = new();

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }



        private void authorizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormIsValid())
                {
                    UserThatSignsIn.Email = emailValue.Text;
                    UserThatSignsIn.Password = passwordValue.Text;

                    UserModel UserModelFromDatabase = GetSingleUser(UserThatSignsIn);

                    if (UserModelFromDatabase != null)
                    {
                        UserThatSignsIn.Id = UserModelFromDatabase.Id;
                        UserThatSignsIn.Role = UserModelFromDatabase.Role;

                        if (UserThatSignsIn.Role == "Admin")
                        {
                            Form1 form = new(UserModelFromDatabase);
                            form.ShowDialog();
                        }
                        else
                        {
                            StudentPersonalCabinetForm studentPersonalCabinetForm = new();
                            studentPersonalCabinetForm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("მომხმარებელივერ მოიძებნა", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("არასწორი ინფორამაცია", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void registrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new();
            registrationForm.ShowDialog();
        }


        private UserModel GetSingleUser(UserModel modelToCheck)
        {
            UserModel result = _userService
                .GetAllUsers()
                .FirstOrDefault(x => x.Email.Contains(UserThatSignsIn.Email, StringComparison.OrdinalIgnoreCase));

            return result;
        }

        private bool FormIsValid() =>
            emailValue.Text.Contains('@')
            && emailValue.Text.Contains('.')
            && !string.IsNullOrWhiteSpace(emailValue.Text)
            && !string.IsNullOrWhiteSpace(passwordValue.Text);

    }
}
