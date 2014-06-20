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
        private Boolean rockGlobal = false;

        private Boolean paperGlobal = false;
        private Boolean scissorsGlobal = false;

        public void UpdateButtons(Boolean rockButtonDown, Boolean paperButtonDown, Boolean scissorsButtonDown)
        {
            if (rockButtonDown == true)
            {
                rockGlobal = true;
                paperGlobal = false;
                scissorsGlobal = false;

                rockButton.Enabled = true;
                paperButton.Enabled = false;
                scissorsButton.Enabled = false;
            }
            else
            {
                if (paperButtonDown == true)
                {
                    rockGlobal = false;
                    paperGlobal = true;
                    scissorsGlobal = false;

                    rockButton.Enabled = false;
                    paperButton.Enabled = true;
                    scissorsButton.Enabled = false;
                }
                else
                {
                    if (scissorsButtonDown == true)
                    {
                        rockGlobal = false;
                        paperGlobal = false;
                        scissorsGlobal = true;

                        rockButton.Enabled = false;
                        paperButton.Enabled = false;
                        scissorsButton.Enabled = true;
                    }
                }
            }
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
            UpdateButtons(true, false, false);
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            UpdateButtons(false, true, false);
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            UpdateButtons(false, false, true);
        }
    }
}