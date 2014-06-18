using Multi_Tool_V3.Properties;
using System;
using System.Windows.Forms;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class RollTheDice : Form
    {
        private readonly Random gen = new Random();
        private int difference = 9;
        private int endingNumber = 10;
        private int rolledNumber;
        private int startingNumber = 1;

        public RollTheDice()
        {
            InitializeComponent();
        }

        private void RollTheDice_Load(object sender, EventArgs e)
        {
            var username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startingNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (startingNumberTextBox.Text != (""))
            {
                startingNumber = Convert.ToInt32(startingNumberTextBox.Text);
            }
        }

        private void endingNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (endingNumberTextBox.Text != (""))
            {
                endingNumber = Convert.ToInt32(endingNumberTextBox.Text);
            }
        }

        private void rollNumberButton_Click(object sender, EventArgs e)
        {
            difference = endingNumber - startingNumber;
            rolledNumber = gen.Next(difference) + startingNumber;
            randomNumberLabel.Text = Convert.ToString(rolledNumber);
            Multi_Tool_V3.Properties.Settings.Default.numberOfDiceRolls =
                Multi_Tool_V3.Properties.Settings.Default.numberOfDiceRolls + 1;
            Multi_Tool_V3.Properties.Settings.Default.Save();
        }

        private void startingNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            startingNumberTextBox.Text = ("");
        }

        private void endingNumberTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            endingNumberTextBox.Text = ("");
        }
    }
}