using System;
using System.Drawing;
using System.Windows.Forms;
using Multi_Tool_V3.Properties;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class RockPaperScissors : Form
    {
        //Variables
        private readonly Random gen = new Random();

        private Boolean humanWon;

        private Boolean paperGlobal;
        private Boolean paperRobot;
        private Boolean rockGlobal;
        private Boolean rockRobot;
        private Boolean scissorsGlobal;
        private Boolean scissorsRobot;
        private Boolean tieOccured;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        public void RobotChoose()
        {
            int randomNumber = gen.Next(3);
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

        public void UpdateButtons()
        {
            if (rockGlobal)
            {
                rockButton.ForeColor = Color.Green;
                paperButton.ForeColor = Color.Red;
                scissorsButton.ForeColor = Color.Red;
            }
            else
            {
                if (paperGlobal)
                {
                    rockButton.ForeColor = Color.Red;
                    paperButton.ForeColor = Color.Green;
                    scissorsButton.ForeColor = Color.Red;
                }
                else
                {
                    if (scissorsGlobal)
                    {
                        rockButton.ForeColor = Color.Red;
                        paperButton.ForeColor = Color.Red;
                        scissorsButton.ForeColor = Color.Green;
                    }
                }
            }
        }

        public void WhoWon()
        {
            //Who Won Code
            if (rockGlobal)
            {
                if (rockRobot)
                {
                    tieOccured = true;
                }
                else
                {
                    if (paperRobot)
                    {
                        humanWon = false;
                    }
                    else
                    {
                        if (scissorsRobot)
                        {
                            humanWon = true;
                        }
                    }
                }
            }
            else
            {
                if (paperGlobal)
                {
                    if (paperRobot)
                    {
                        tieOccured = true;
                    }
                    else
                    {
                        if (rockRobot)
                        {
                            humanWon = true;
                        }
                        else
                        {
                            if (scissorsRobot)
                            {
                                humanWon = false;
                            }
                        }
                    }
                }
                else
                {
                    if (scissorsGlobal)
                    {
                        if (scissorsRobot)
                        {
                            tieOccured = true;
                        }
                        else
                        {
                            if (rockRobot)
                            {
                                humanWon = false;
                            }
                            else
                            {
                                if (paperRobot)
                                {
                                    humanWon = true;
                                }
                            }
                        }
                    }
                }
            }

            //Winner Display Code
            if (tieOccured)
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
            Close();
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

        private void rockButton_Click(object sender, EventArgs e)
        {
            rockGlobal = true;
            paperGlobal = false;
            scissorsGlobal = false;
            UpdateButtons();
            RobotChoose();
            WhoWon();
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
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