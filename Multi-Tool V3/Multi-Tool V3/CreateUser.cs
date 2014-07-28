using System;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        //Variables
        private string username;

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Text = ("");
        }

        private void checkAvailabilityUsernameButton_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != (""))
            {
                username = usernameTextBox.Text;
            }
        }
    }
}
