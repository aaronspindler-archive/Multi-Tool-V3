using System;
using System.Drawing;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    public partial class CreateUser : Form
    {
        private string inputPassword;
        private string inputUsername;
        private string pass1;
        private string pass2;
        private Boolean passwordsAreTheSame;

        public CreateUser()
        {
            InitializeComponent();
        }

        public void checkPasswords()
        {
            if (pass1 == pass2)
            {
                passwordsAreTheSame = true;
                passwordsSameLabel.ForeColor = Color.Chartreuse;
                passwordsSameLabel.Text = ("Passwords are the same!");
            }
            else
            {
                if (pass1 != pass2)
                {
                    passwordsAreTheSame = false;
                    passwordsSameLabel.ForeColor = Color.Red;
                    passwordsSameLabel.Text = ("Passwords are not the same!");
                }
            }
        }

        private void checkAvailabilityUsernameButton_Click(object sender, EventArgs e)
        {
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void password1TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            password1TextBox.Text = ("");
        }

        private void password1TextBox_TextChanged(object sender, EventArgs e)
        {
            pass1 = password1TextBox.Text;
            checkPasswords();
        }

        private void password2TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            password2TextBox.Text = ("");
        }

        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            pass2 = password2TextBox.Text;
            checkPasswords();
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Text = ("");
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != (""))
            {
                inputUsername = usernameTextBox.Text;
            }
        }
    }
}