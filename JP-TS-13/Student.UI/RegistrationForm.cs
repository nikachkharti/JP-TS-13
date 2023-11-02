using Student.Models;
using Student.Service;
using Student.Service.Interfaces;
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
    public partial class RegistrationForm : Form
    {
        private readonly IUserService _userService;
        public RegistrationForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (FormIsValid())
                {
                    UserModel newUser = new()
                    {
                        Email = emailValue.Text,
                        Password = passwordValue.Text,
                        Role = "Student"
                    };
                    MessageBox.Show("მომხმარებელი დარეგისტრირდა", "წარმატებული მოქმედება", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (EmailIsUnique(newUser))
                    {
                        _userService.AddUser(newUser);
                    }
                    else
                    {
                        MessageBox.Show("მომხმარებელი უკვე არსებობს", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private bool FormIsValid() =>
            emailValue.Text.Contains('@')
            && emailValue.Text.Contains('.')
            && !string.IsNullOrWhiteSpace(emailValue.Text)
            && !string.IsNullOrWhiteSpace(passwordValue.Text);

        private bool EmailIsUnique(UserModel model) => !_userService.GetAllUsers().Any(x => x.Email.Contains(model.Email, StringComparison.OrdinalIgnoreCase));

    }
}
