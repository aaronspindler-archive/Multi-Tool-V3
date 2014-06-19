using System;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        //Variables


        public void UpdateButtons(Boolean rockButtonDown, Boolean paperButtonDown, Boolean scissorsButtonDown)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void rockButton_Click(object sender, EventArgs e)
        {

        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}