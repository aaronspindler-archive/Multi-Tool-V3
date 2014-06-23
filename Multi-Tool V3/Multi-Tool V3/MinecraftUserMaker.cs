using System;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class MinecraftUserMaker : Form
    {
        public MinecraftUserMaker()
        {
            InitializeComponent();
        }

        //Variables
        private string username = ("");
        private Boolean customPassUsed = false;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinecraftUserMaker_Load(object sender, EventArgs e)
        {
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mums = new MinecraftUserMakerSettings();
            mums.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != (""))
            {
                username = usernameTextBox.Text;
            }
        }

        private void customPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (customPasswordCheckBox.Checked)
            {
                case true:
                    customPasswordTextBox.Enabled = true;
                    customPassUsed = true;
                    break;
                case false:
                    customPasswordTextBox.Enabled = false;
                    customPassUsed = false;
                    break;
            }
        }
    }
}