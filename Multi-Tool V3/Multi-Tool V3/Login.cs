using System;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class Login : Form
    {
        //Variables
        private string error = ("");

        private string password = ("");

        private string username = ("");

        public Login()
        {
            InitializeComponent();
        }

        public void CheckForText()
        {
            if ((usernameTextBox.Text == ("")) || (passwordTextBox.Text == ("")))
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }

        public void ErrorOccured()
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoginCheck()
        {
            if ((username == ("xNovax")) && (password == ("password")))
            {
                var homeWindow = new Home();
                Multi_Tool_V3.Properties.Settings.Default.username = username;
                Multi_Tool_V3.Properties.Settings.Default.Save();
                homeWindow.Show();
                Hide();
            }
            else
            {
                error = ("Wrong Username or Password");
                ErrorOccured();
                Multi_Tool_V3.Properties.Settings.Default.username = username;
            }
            Multi_Tool_V3.Properties.Settings.Default.username = username;
            Multi_Tool_V3.Properties.Settings.Default.Save();
        }

        private void createNewUserButton_Click(object sender, EventArgs e)
        {
            error = ("Feature not yet implemented");
            ErrorOccured();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CheckForText();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginCheck();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            password = passwordTextBox.Text;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            username = usernameTextBox.Text;
            Multi_Tool_V3.Properties.Settings.Default.username = username;
        }
    }
}