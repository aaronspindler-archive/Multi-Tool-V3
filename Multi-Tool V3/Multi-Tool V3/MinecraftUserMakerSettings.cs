//@author xNovax
using System;
using System.Windows.Forms;
using Multi_Tool_V3.Properties;

namespace Multi_Tool_V3
{
    public partial class MinecraftUserMakerSettings : Form
    {
        //Variables
        private int passwordLength = 8;
        private int passwordType;
        private string rootServerIP = ("192.168.1.1");
        private string ftpPort = ("8821");

        public MinecraftUserMakerSettings()
        {
            InitializeComponent();
        }

        public void SaveSettings()
        {
            Settings.Default.minecraftPasswordLength = passwordLength;
            Settings.Default.minecraftPasswordType = passwordType;
            Settings.Default.minecraftUserMakerRootIP = rootServerIP;
            Settings.Default.minecraftFtpPort = ftpPort;
            Settings.Default.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinecraftUserMakerSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void MinecraftUserMakerSettings_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);

            if (Settings.Default.minecraftPasswordLength != 8)
            {
                passwordLengthTextBox.Text = (Convert.ToString(Settings.Default.minecraftPasswordLength));
                passwordLength = Settings.Default.minecraftPasswordLength;
            }

            passwordTypeCombo.SelectedIndex = Settings.Default.minecraftPasswordType;
            rootServerIPTextBox.Text = Settings.Default.minecraftUserMakerRootIP;
            ftpPortTextBox.Text = Settings.Default.minecraftFtpPort;
        }

        private void passwordLengthTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordLengthTextBox.Text = ("");
        }

        private void passwordLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordLengthTextBox.Text != (""))
            {
                passwordLength = Convert.ToInt32(passwordLengthTextBox.Text);
            }
        }

        private void passwordTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (passwordTypeCombo.SelectedIndex)
            {
                case 0:
                    passwordType = 1;
                    break;

                case 1:
                    passwordType = 2;
                    break;

                case 2:
                    passwordType = 3;
                    break;

                case 3:
                    passwordType = 4;
                    break;

                default:
                    passwordType = 0;
                    break;
            }
        }

        private void rootServerIPTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            rootServerIPTextBox.Text = ("");
        }

        private void rootServerIPTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rootServerIPTextBox.Text != (""))
            {
                rootServerIP = rootServerIPTextBox.Text;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ftpPortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            ftpPortTextBox.Text = ("");
        }

        private void ftpPortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ftpPortTextBox.Text != (""))
            {
                ftpPort = ftpPortTextBox.Text;
            }
        }
    }
}