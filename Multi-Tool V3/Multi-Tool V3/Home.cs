using System;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Variables
        private UsefulCode uc = new UsefulCode();

        private string time;

        private void Home_Load(object sender, EventArgs e)
        {
            time = uc.GetCurrentTime();
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
            timeDisplay.Text = ("Current Time: " + time);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randomPasswordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpg = new RandomPasswordGen();
            rpg.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = uc.GetCurrentTime();
            timeDisplay.Text = ("Current Time: " + time);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = new Information();
            info.Show();
        }

        private void rollTheDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rtd = new RollTheDice();
            rtd.Show();
        }

        private void listRandomizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lr = new ListRandomizer();
            lr.Show();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stats = new ProgramStatistics();
            stats.Show();
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var con = new Converter();
            con.Show();
        }

        private void rockPaperScissorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rps = new RockPaperScissors();
            rps.Show();
        }
    }
}