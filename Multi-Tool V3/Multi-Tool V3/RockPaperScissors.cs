using System;
using System.Drawing;
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
        private Random gen = new Random();
        private Boolean rockGlobal = false;
        private Boolean paperGlobal = false;
        private Boolean scissorsGlobal = false;
        private Boolean rockRobot = false;
        private Boolean paperRobot = false;
        private Boolean scissorsRobot = false;

        public void UpdateButtons()
        {
            if (rockGlobal == true)
            {
                rockButton.ForeColor = Color.Green;
                paperButton.ForeColor = Color.Red;
                scissorsButton.ForeColor = Color.Red;
            }
            else
            {
                if (paperGlobal == true)
                {
                    rockButton.ForeColor = Color.Red;
                    paperButton.ForeColor = Color.Green;
                    scissorsButton.ForeColor = Color.Red;
                }
                else
                {
                    if (scissorsGlobal == true)
                    {
                        rockButton.ForeColor = Color.Red;
                        paperButton.ForeColor = Color.Red;
                        scissorsButton.ForeColor = Color.Green;
                    }
                }
            }
        }

        public void RobotChoose()
        {
            var randomNumber = gen.Next(3);
            if (randomNumber == 0)
            {
                rockRobot = true;
                paperRobot = false;
                scissorsRobot = false;
                robotsChoiceDisplay.Text = ("Player 2: Rock");
            }
            else
            {
                if (randomNumber == 1)
                {
                    rockRobot = false;
                    paperRobot = true;
                    scissorsRobot = false;
                    robotsChoiceDisplay.Text = ("Player 2: Paper");
                }
                else
                {
                    if (randomNumber == 2)
                    {
                        rockRobot = false;
                        paperRobot = false;
                        scissorsRobot = true;
                        robotsChoiceDisplay.Text = ("Player 2: Scissors");
                    }
                }
            }
        }

        public void WhoWon()
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
            rockGlobal = true;
            paperGlobal = false;
            scissorsGlobal = false;
            UpdateButtons();
            RobotChoose();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            rockGlobal = false;
            paperGlobal = true;
            scissorsGlobal = false;
            UpdateButtons();
            RobotChoose();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            rockGlobal = false;
            paperGlobal = false;
            scissorsGlobal = true;
            UpdateButtons();
            RobotChoose();
        }
    }
}