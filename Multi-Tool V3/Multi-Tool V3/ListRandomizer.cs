using System;
using System.Collections.Generic;
using System.Windows.Forms;

//@author xNovax
namespace Multi_Tool_V3
{
    public partial class ListRandomizer : Form
    {
        private Random gen = new Random();

        //Variables
        private string itemToAdd = ("");

        private int numItemsInList = 0;

        private List<string> originalList = new List<string>();

        private List<string> randomList = new List<string>();

        private int randomNumber = 0;

        public ListRandomizer()
        {
            InitializeComponent();
        }

        public void ErrorOccured(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            originalList.Add(itemToAdd);
            numberOfItemsDisplay.Text = (Convert.ToString(originalList.Count));

            if (originalList.Count != 0)
            {
                clearListButton.Enabled = true;
                randomizeListButton.Enabled = true;
            }
            else
            {
                clearListButton.Enabled = false;
                randomizeListButton.Enabled = false;
            }
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            clearListButton.Enabled = false;
            randomizeListButton.Enabled = false;
            addItemButton.Enabled = true;
            originalList.Clear();
            randomList.Clear();
            numberOfItemsDisplay.Text = ("0");
            randomizedListBox.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemAdditionTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            itemAdditionTextBox.Text = ("");
        }

        private void itemAdditionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemAdditionTextBox.Text != (""))
            {
                itemToAdd = itemAdditionTextBox.Text;
            }
        }

        private void ListRandomizer_Load(object sender, EventArgs e)
        {
            var username = Properties.Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
            clearListButton.Enabled = false;
            randomizeListButton.Enabled = false;
            itemAdditionTextBox.Text = ("Example: " + username);
        }

        private void randomizeListButton_Click(object sender, EventArgs e)
        {
            randomizeListButton.Enabled = false;
            addItemButton.Enabled = false;
            numItemsInList = originalList.Count;

            while (originalList.Count > 0)
            {
                randomNumber = gen.Next(0, originalList.Count);
                randomList.Add(originalList[randomNumber]);
                originalList.RemoveAt(randomNumber);
            }

            if (randomList != null) randomizedListBox.Items.AddRange(randomList.ToArray());
            Properties.Settings.Default.numberOfListsRandomized =
            Properties.Settings.Default.numberOfListsRandomized + 1;
            Properties.Settings.Default.Save();
        }
    }
}