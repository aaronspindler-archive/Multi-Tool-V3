using Multi_Tool_V3.Properties;
using System;
using System.Windows.Forms;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class Converter : Form
    {
        private int fromSelected = 0;
        private UsefulCode uc = new UsefulCode();

        public Converter()
        {
            InitializeComponent();
        }

        public void SetItems()
        {
            if (fromComboBox.SelectedIndex == 0)
            {
                fromSelected = 0;
            }
            else
            {
                if (fromComboBox.SelectedIndex == 1)
                {
                    fromSelected = 1;
                }
                else
                {
                    if (fromComboBox.SelectedIndex == 2)
                    {
                        fromSelected = 2;
                    }
                    else
                    {
                        if (fromComboBox.SelectedIndex == 3)
                        {
                            fromSelected = 3;
                        }
                        else
                        {
                            if (fromComboBox.SelectedIndex == 4)
                            {
                                fromSelected = 4;
                            }
                            else
                            {
                                if (fromComboBox.SelectedIndex == 5)
                                {
                                    fromSelected = 5;
                                }
                                else
                                {
                                    if (fromComboBox.SelectedIndex == 6)
                                    {
                                        fromSelected = 6;
                                    }
                                    else
                                    {
                                        if (fromComboBox.SelectedIndex == 7)
                                        {
                                            fromSelected = 7;
                                        }
                                        else
                                        {
                                            if (fromComboBox.SelectedIndex == 8)
                                            {
                                                fromSelected = 8;
                                            }
                                            else
                                            {
                                                if (fromComboBox.SelectedIndex == 9)
                                                {
                                                    fromSelected = 9;
                                                }
                                                else
                                                {
                                                    if (fromComboBox.SelectedIndex == 10)
                                                    {
                                                        fromSelected = 10;
                                                    }
                                                    else
                                                    {
                                                        if (fromComboBox.SelectedIndex == 11)
                                                        {
                                                            fromSelected = 11;
                                                        }
                                                        else
                                                        {
                                                            if (fromComboBox.SelectedIndex == 12)
                                                            {
                                                                fromSelected = 12;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            string username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetItems();
        }

        private void fromValueTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            fromValueTextBox.Text = ("");
        }

        private void toComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}