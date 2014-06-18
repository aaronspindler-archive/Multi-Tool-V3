using Multi_Tool_V3.Properties;
using System;
using System.Windows.Forms;

//@author xNovax

namespace Multi_Tool_V3
{
    public partial class RandomPasswordGenOptions : Form
    {
        private Boolean allCharactersChecked;
        private Boolean numbersAndLettersChecked;
        private Boolean numbersAndLowerChecked;
        private Boolean numbersChecked;

        public RandomPasswordGenOptions()
        {
            InitializeComponent();
        }

        private void RandomPasswordGenOptions_Load(object sender, EventArgs e)
        {
            var username = Settings.Default.username;
            usernameDisplay.Text = ("Logged in as: " + username);

            switch (Settings.Default.randomPasswordSetting)
            {
                case 1:
                    numbersCheckBox.Checked = true;
                    numbersChecked = true;
                    SetSelection();
                    break;

                case 2:
                    lowerAndNumbersCheckBox.Checked = true;
                    numbersAndLowerChecked = true;
                    SetSelection();
                    break;

                case 3:
                    lettersAndNumbersCheckBox.Checked = true;
                    numbersAndLettersChecked = true;
                    SetSelection();
                    break;

                case 4:
                    allCharactersCheckBox.Checked = true;
                    allCharactersChecked = true;
                    SetSelection();
                    break;

                default:
                    SetSelection();
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numbersOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (numbersCheckBox.Checked)
            {
                numbersChecked = true;
            }
            else
            {
                if (numbersCheckBox.Checked == false)
                {
                    numbersChecked = false;
                }
            }
            SetSelection();
        }

        private void lowerCaseAndNumbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerAndNumbersCheckBox.Checked)
            {
                numbersAndLowerChecked = true;
            }
            else
            {
                if (lowerAndNumbersCheckBox.Checked == false)
                {
                    numbersAndLowerChecked = false;
                }
            }
            SetSelection();
        }

        private void allLettersAndNumbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lettersAndNumbersCheckBox.Checked)
            {
                numbersAndLettersChecked = true;
            }
            else
            {
                if (lettersAndNumbersCheckBox.Checked == false)
                {
                    numbersAndLettersChecked = false;
                }
            }
            SetSelection();
        }

        private void allLettersNumbersAndCharactersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCharactersCheckBox.Checked)
            {
                allCharactersChecked = true;
            }
            else
            {
                if (allCharactersCheckBox.Checked == false)
                {
                    allCharactersChecked = false;
                }
            }
            SetSelection();
        }

        public void SetSelection()
        {
            if (numbersChecked)
            {
                numbersCheckBox.Checked = true;
                lowerAndNumbersCheckBox.Checked = false;
                lettersAndNumbersCheckBox.Checked = false;
                allCharactersCheckBox.Checked = false;

                numbersCheckBox.Enabled = true;
                lowerAndNumbersCheckBox.Enabled = false;
                lettersAndNumbersCheckBox.Enabled = false;
                allCharactersCheckBox.Enabled = false;

                numbersChecked = true;
                numbersAndLowerChecked = false;
                numbersAndLettersChecked = false;
                allCharactersChecked = false;

                Settings.Default.randomPasswordSetting = 1;
            }
            else
            {
                if (numbersAndLowerChecked)
                {
                    numbersCheckBox.Checked = false;
                    lowerAndNumbersCheckBox.Checked = true;
                    lettersAndNumbersCheckBox.Checked = false;
                    allCharactersCheckBox.Checked = false;

                    numbersCheckBox.Enabled = false;
                    lowerAndNumbersCheckBox.Enabled = true;
                    lettersAndNumbersCheckBox.Enabled = false;
                    allCharactersCheckBox.Enabled = false;

                    numbersChecked = false;
                    numbersAndLowerChecked = true;
                    numbersAndLettersChecked = false;
                    allCharactersChecked = false;

                    Settings.Default.randomPasswordSetting = 2;
                }
                else
                {
                    if (numbersAndLettersChecked)
                    {
                        numbersCheckBox.Checked = false;
                        lowerAndNumbersCheckBox.Checked = false;
                        lettersAndNumbersCheckBox.Checked = true;
                        allCharactersCheckBox.Checked = false;

                        numbersCheckBox.Enabled = false;
                        lowerAndNumbersCheckBox.Enabled = false;
                        lettersAndNumbersCheckBox.Enabled = true;
                        allCharactersCheckBox.Enabled = false;

                        numbersChecked = false;
                        numbersAndLowerChecked = false;
                        numbersAndLettersChecked = true;
                        allCharactersChecked = false;

                        Settings.Default.randomPasswordSetting = 3;
                    }
                    else
                    {
                        if (allCharactersChecked)
                        {
                            numbersCheckBox.Checked = false;
                            lowerAndNumbersCheckBox.Checked = false;
                            lettersAndNumbersCheckBox.Checked = false;
                            allCharactersCheckBox.Checked = true;

                            numbersCheckBox.Enabled = false;
                            lowerAndNumbersCheckBox.Enabled = false;
                            lettersAndNumbersCheckBox.Enabled = false;
                            allCharactersCheckBox.Enabled = true;

                            numbersChecked = false;
                            numbersAndLowerChecked = false;
                            numbersAndLettersChecked = false;
                            allCharactersChecked = true;

                            Settings.Default.randomPasswordSetting = 4;
                        }
                        else
                        {
                            numbersCheckBox.Checked = false;
                            lowerAndNumbersCheckBox.Checked = false;
                            lettersAndNumbersCheckBox.Checked = false;
                            allCharactersCheckBox.Checked = false;

                            numbersCheckBox.Enabled = true;
                            lowerAndNumbersCheckBox.Enabled = true;
                            lettersAndNumbersCheckBox.Enabled = true;
                            allCharactersCheckBox.Enabled = true;

                            numbersChecked = false;
                            numbersAndLowerChecked = false;
                            numbersAndLettersChecked = false;
                            allCharactersChecked = false;

                            Settings.Default.randomPasswordSetting = 0;
                        }
                    }
                }
            }

            Settings.Default.Save();
        }
    }
}