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
        private Boolean humanWon = false;
        private Boolean tieOccured = false;

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
            switch (randomNumber)
            {
                case 0:
                    rockRobot = true;
                    paperRobot = false;
                    scissorsRobot = false;
                    robotsChoiceDisplay.Text = ("Bot: Rock");
                    break;
                case 1:
                    rockRobot = false;
                    paperRobot = true;
                    scissorsRobot = false;
                    robotsChoiceDisplay.Text = ("Bot: Paper");
                    break;
                case 2:
                    rockRobot = false;
                    paperRobot = false;
                    scissorsRobot = true;
                    robotsChoiceDisplay.Text = ("Bot: Scissors");
                    break;
            }
        }

        public void WhoWon()
        {
            //Who Won Code
            if ((rockGlobal == true) && (scissorsRobot == true))
            {
                humanWon = true;
            }
            else
            {
                if ((paperGlobal == true) && (rockRobot == true))
                {
                    humanWon = true;
                }
                else
                {
                    if ((scissorsGlobal == true) && (paperRobot == true))
                    {
                        humanWon = true;
                    }
                }
            }


            //Winner Display Code
            if (tieOccured == true)
            {
                winnerDisplay.Text = ("Tie Game!");
                humanWon = false;
                tieOccured = false;
            }
            else
            {
                if (tieOccured == false)
                {
                    switch (humanWon)
                    {
                        case true:
                            winnerDisplay.Text = ("You have won!");
                            humanWon = false;
                            break;
                        case false:
                            winnerDisplay.Text = ("You have lost!");
                            humanWon = false;
                            break;
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
            rockGlobal = true;
            paperGlobal = false;
            scissorsGlobal = false;
            UpdateButtons();
            RobotChoose();
            WhoWon();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            rockGlobal = false;
            paperGlobal = true;
            scissorsGlobal = false;
            UpdateButtons();
            RobotChoose();
            WhoWon();
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            rockGlobal = false;
            paperGlobal = false;
            scissorsGlobal = true;
            UpdateButtons();
            RobotChoose();
            WhoWon();
        }
    }
}