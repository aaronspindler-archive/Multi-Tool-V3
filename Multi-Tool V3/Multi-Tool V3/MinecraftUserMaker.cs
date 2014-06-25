using System;
using System.IO;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class MinecraftUserMaker : Form
    {
        private UsefulCode uc = new UsefulCode();
        private Boolean customPassUsed = false;
        private string username = ("");
        private string customPassword = ("");
        private string mcServerPort = ("");
        private string controlPanelPort = ("");

        public MinecraftUserMaker()
        {
            InitializeComponent();
        }

        public string WhichPassword()
        {
            var passwordToPrint = ("");

            switch (customPassUsed)
            {
                case true:
                    passwordToPrint = customPassword;
                    break;

                case false:
                    passwordToPrint = uc.MakeRandomPassword(Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordType, Multi_Tool_V3.Properties.Settings.Default.minecraftPasswordLength);
                    break;
            }
            return passwordToPrint;
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

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Text = ("");
        }

        private void customPasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            customPasswordTextBox.Text = ("");
        }

        private void mcServerPortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            mcServerPortTextBox.Text = ("");
        }

        private void customPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (customPasswordTextBox.Text != (""))
            {
                customPassword = customPasswordTextBox.Text;
            }
        }

        private void mcServerPortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (mcServerPortTextBox.Text != (""))
            {
                mcServerPort = mcServerPortTextBox.Text;
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            if ((usernameTextBox.Text == ("")) || (mcServerPortTextBox.Text == ("")))
            {
                uc.ErrorOccured("Please fill in the username and/or minecraft server port field.");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var writer = new StreamWriter(saveFileDialog1.FileName);
                    writer.WriteLine("Minecraft User File");
                    writer.WriteLine("Time Created: " + uc.GetCurrentTime());
                    writer.WriteLine("=================================================");
                    writer.WriteLine("Minecraft Server Information");
                    writer.WriteLine("Minecraft Server IP: " + Multi_Tool_V3.Properties.Settings.Default.minecraftUserMakerRootIP + ":" + mcServerPort);
                    writer.WriteLine("=================================================");
                    writer.WriteLine("Control Panel Information");
                    writer.WriteLine("Control Panel IP: " + Multi_Tool_V3.Properties.Settings.Default.minecraftUserMakerRootIP + ":" + controlPanelPort);
                    writer.WriteLine("Control Panel Username: " + username);
                    writer.WriteLine("Control Panel Password: " + WhichPassword());
                    writer.WriteLine("=================================================");
                    writer.WriteLine("FTP Information");
                    writer.WriteLine("FTP IP: " + Multi_Tool_V3.Properties.Settings.Default.minecraftUserMakerRootIP + ":" + Multi_Tool_V3.Properties.Settings.Default.minecraftFtpPort);
                    writer.WriteLine("FTP Username: " + username);
                    writer.WriteLine("FTP Password: " + WhichPassword());
                    writer.WriteLine("=================================================");
                    writer.Close();
                }
                else
                {
                    uc.ErrorOccured("Please select a file then click ok");
                }
            }
        }

        private void controlPanelPortTextBox_TextChanged(object sender, EventArgs e)
        {
            if (controlPanelPortTextBox.Text != (""))
            {
                controlPanelPort = controlPanelPortTextBox.Text;
            }
        }

        private void controlPanelPortTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            controlPanelPortTextBox.Text = ("");
        }
    }
}