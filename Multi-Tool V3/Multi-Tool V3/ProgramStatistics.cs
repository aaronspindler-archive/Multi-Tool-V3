using System;
using System.Windows.Forms;
using Multi_Tool_V3.Properties;

namespace Multi_Tool_V3
{
    public partial class ProgramStatistics : Form
    {
        public ProgramStatistics()
        {
            InitializeComponent();
        }

        public void ErrorOccured(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RefreshEverything()
        {
            numberOfPasswordsCreatedDisplay.Text = Convert.ToString(Settings.Default.numberOfPasswordsCreated);
            numberOfDiceRolledDisplay.Text = Convert.ToString(Settings.Default.numberOfDiceRolls);
            numListsRandomizedDisplay.Text = Convert.ToString(Settings.Default.numberOfListsRandomized);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numberOfDiceRolledResetButton_Click(object sender, EventArgs e)
        {
            numberOfDiceRolledDisplay.Text = ("0");
            Settings.Default.numberOfDiceRolls = 0;
            Settings.Default.Save();
            RefreshEverything();
        }

        private void numberOfPasswordsResetButton_Click(object sender, EventArgs e)
        {
            numberOfPasswordsCreatedDisplay.Text = ("0");
            Settings.Default.numberOfPasswordsCreated = 0;
            Settings.Default.Save();
            RefreshEverything();
        }

        private void numListsRandomizedResetButton_Click(object sender, EventArgs e)
        {
            numListsRandomizedDisplay.Text = ("0");
            Settings.Default.numberOfListsRandomized = 0;
            Settings.Default.Save();
            RefreshEverything();
        }

        private void ProgramStatistics_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);

            numberOfPasswordsCreatedDisplay.Text = Convert.ToString(Settings.Default.numberOfPasswordsCreated);

            numberOfDiceRolledDisplay.Text = Convert.ToString(Settings.Default.numberOfDiceRolls);

            numListsRandomizedDisplay.Text = Convert.ToString(Settings.Default.numberOfListsRandomized);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshEverything();
        }
    }
}