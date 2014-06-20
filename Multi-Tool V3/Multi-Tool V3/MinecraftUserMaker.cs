using System;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    public partial class MinecraftUserMaker : Form
    {
        public MinecraftUserMaker()
        {
            InitializeComponent();
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
    }
}
