using System;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class MinecraftUserMakerSettings : Form
    {
        //Variables
        private int passwordLength = 8;

        private int passwordType = 0;

        public MinecraftUserMakerSettings()
        {
            InitializeComponent();
        }

        public void SaveSettings()
        {
            Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordLength = passwordLength;
            Multi_Tool_V3.Properties.Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinecraftUserMakerSettings_Load(object sender, EventArgs e)
        {
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);

            if (Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordLength != 8)
            {
                passwordLengthTextBox.Text = (Convert.ToString(Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordLength));
                passwordLength = Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordLength;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void passwordLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordLengthTextBox.Text != (""))
            {
                passwordLength = Convert.ToInt32(passwordLengthTextBox.Text);
            }
        }

        private void passwordLengthTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordLengthTextBox.Text = ("");
        }

        private void MinecraftUserMakerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void passwordTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (passwordTypeCombo.SelectedIndex == 0)
            {
                passwordType = 1;
            }
            else
            {
                if (passwordTypeCombo.SelectedIndex == 1)
                {
                    passwordType = 2;
                }
                else
                {
                    if (passwordTypeCombo.SelectedIndex == 2)
                    {
                        passwordType = 3;
                    }
                    else
                    {
                        if (passwordTypeCombo.SelectedIndex == 3)
                        {
                            passwordType = 4;
                        }
                        else
                        {
                            passwordType = 0;
                        }
                    }
                }
            }
        }
    }
}