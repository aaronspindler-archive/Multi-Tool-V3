using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_V3
{
    public partial class MinecraftUserMakerSettings : Form
    {
        public MinecraftUserMakerSettings()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinecraftUserMakerSettings_Load(object sender, EventArgs e)
        {
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }
    }
}
